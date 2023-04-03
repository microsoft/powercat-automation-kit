//    THE SAMPLE SOLUTION IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using AutoCoE.Extensibility.Plugins.DataModel;
using AutoCoE.Extensibility.Plugins.PluginHelper;

namespace AutoCoE.Extensibility.Plugins
{
    /// <summary>
    /// The Machine Status Monitoring sample solution increases visibility of machine status across an environment. 
    /// This plugin will retrieve the current and previously known machine statuses and upsert or delete these in case of a status change.  
    /// Each machine status log update record will have the following statistics:
    ///     New Machines = The number of new machines added.
    ///     Updated Machines = The number of machines that have an update on their status(Example: Online to Offline)
    ///     Deleted Machines = Machines that have been deleted. (Orphaned machines will count as deleted when they orphan)
    ///     Offline Machines = The amount of offline machines.
    ///     Orphaned Machines = The amount of orphaned machines. (If environment variable flags are on to detect orphans)
    ///     NotRegistered Machines = The amount of machines that are not registered.These machines have to be manually deleted.If there is a NotRegistered machine, the Has Machines that need action will be visible. (See below)
    /// </summary>    
    /// <remarks>
    /// GitHub Repo of the sample solution: https://github.com/rpapostolis/autocoe-extensibility.git
    /// </remarks>
    public class UpdateDesktopFlowMachineStatusLogs : PluginBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDesktopFlowMachineStatusLogs"/> class.
        /// </summary>
        /// <param name="unsecure">Contains public (unsecured) configuration information.</param>
        /// <param name="secure">Contains non-public (secured) configuration information. 
        /// When using Microsoft Dynamics 365 for Outlook with Offline Access, 
        /// the secure string is not passed to a plug-in that executes while the client is offline.</param>
        public UpdateDesktopFlowMachineStatusLogs(string unsecure, string secure)
            : base(typeof(UpdateDesktopFlowMachineStatusLogs))
        { }

        /// <summary>
        /// Main entry point for he business logic that the plug-in is to execute.
        /// </summary>
        /// <param name="localContext">The <see cref="LocalPluginContext"/> which contains the
        /// <see cref="IPluginExecutionContext"/>,
        /// <see cref="IOrganizationService"/>
        /// and <see cref="ITracingService"/>
        /// </param>
        /// <remarks>
        /// For improved performance, Microsoft Dynamics 365 caches plug-in instances.
        /// The plug-in's Execute method should be written to be stateless as the constructor
        /// is not called for every invocation of the plug-in. Also, multiple system threads
        /// could execute the plug-in at the same time. All per invocation state information
        /// is stored in the context. This means that you should not use global variables in plug-ins.
        /// </remarks>
        protected override void ExecuteCdsPlugin(ILocalPluginContext localContext)
        {
            if (localContext == null)
            {
                throw new InvalidPluginExecutionException(nameof(localContext));
            }
            // Obtain the tracing service
            ITracingService tracingService = localContext.TracingService;

            try
            {
                // Obtain the execution context from the service provider.  
                IPluginExecutionContext context = localContext.PluginExecutionContext;

                // Obtain the organization service reference for web service calls.  
                IOrganizationService currentUserService = localContext.CurrentUserService;

                // Check that we are in the right plugin and pipeline execution stage
                if (context.MessageName.Equals("AutoCoE_UpdateDesktopFlowMachineStatusLogs") && context.Stage.Equals(30))
                {
                    // Starting timer to collect overall run time
                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    // Custom API Request Parameters that are supplied by the calling cloud flow and unbound Dataverse action
                    // BatchSize - indicating the number of records to be processed in each batch.
                    // A BatchSize of 500 is a balanced size that will take, depending on server load, approx. 60 seconds to complete for 2.5k VMs
                    int batchSize = (int)context.InputParameters["BatchSize"];

                    // BatchNumber = Number of iterations that are determined by the total Flow Machine count / BatchSize e.g. 2511 / 500 = 5.022 (6 batches).
                    int batchNumber = (int)context.InputParameters["BatchNumber"];

                    // LastBatch = This flag is used to determine whether this is the last batch so that we can do a final outer join to find orphaned machines.
                    bool lastBatch = (bool)context.InputParameters["LastBatch"];

                    // DoAnOrphanedMachineCheck = Indicates whether a final orphaned machine check should be carried out
                    bool doAnOrphanedMachineCheck = (bool)context.InputParameters["DoAnOrphanedMachineCheck"];

                    // DeleteOrphanedMachineStatuses = If the DoAnOrphanedMachineCheck = true then this flag determines whether the Dataverse record should be deleted or just set to Inactive.
                    bool deleteOrphanedMachineStatuses = (bool)context.InputParameters["DeleteOrphanedMachineStatuses"];

                    // Converting the incoming JSON records to custom List of DataverseFlowMachine objects
                    var pagedMachines = PluginUtility
                        .Deserialize<List<DataverseFlowMachine>>((context.InputParameters["PagedFlowMachines"] as string));

                    // Get the machineIds for further processing
                    var machineIds = pagedMachines.Select(m => m.flowmachineid).ToArray();

                    if (machineIds != null && machineIds.Length < 1)
                    {
                        // Tracing Service allows to post debugging and custom logs to Plug-In Trace-Log available under the advanced settings of the Dataverse environment
                        tracingService.Trace($"Automation CoE - UpdateDesktopFlowMachineStatusLogs - Machine Id list is empty - exiting plugin now.");
                        return;
                    }

                    tracingService.Trace($"Automation CoE - UpdateDesktopFlowMachineStatusLogs - BatchSize: {batchSize} & BatchNumber: {batchNumber} Input ");

                    if (batchNumber > 0 && batchSize > 0 && pagedMachines != null && pagedMachines != null)
                    {
                        List<MachineStatus> mStats = new List<MachineStatus>();

                        // The maximum machineId BatchSize per API call is 20
                        int machineIdBatchsize = 20;
                        int currentBatch = 0;

                        // Paging through the input machine list in batches of 20. With a machine count of 2511 and a BatchSize of 20 we would iterate a 126 times
                        while (currentBatch * machineIdBatchsize < pagedMachines.Count)
                        {
                            // Get the paged machineId records in batches of 20
                            var nextBatch = pagedMachines
                                .Skip(currentBatch * machineIdBatchsize)
                                .Take(machineIdBatchsize)
                                .Select(i => i.flowmachineid)
                                .ToArray();

                            // Call the unbound Dataverse API - BatchGetFlowMachineStatus to get the individual machine statuses 
                            var results = GetLiveMachineStatus(currentUserService, nextBatch);

                            if (results != null)
                            {
                                // De-serialize the JSON results and store them in a custom List of MachineStatus objects
                                mStats.AddRange(PluginUtility.Deserialize<List<MachineStatus>>(results));
                            }

                            currentBatch++;
                        }

                        // Create an ExecuteMultipleRequest object below.
                        // Even though product guidance for plugins is to not use ExecuteMultipleRequests,
                        // we're ignoring this here because of the large amount of API calls this might produce.
                        // It should also not have any negative impact on performance, because we're anyhow only updating machines with a changed status.
                        // Only the first time this plugin runs, where no machine status log entry exists, we have potentially larger volumes of machines to update.

                        // Important to note here is that we didn't use the UpsertRequest because this would introduce a higher amount of internal API calls which
                        // can be easily avoided by doing dedicated Inserts and Updates instead.

                        // Power Platform solution checker violation rule will fire when you run the checker: il-avoid-batch-plugin
                        // See more here: https://docs.microsoft.com/en-us/powerapps/developer/data-platform/best-practices/business-logic/avoid-batch-requests-plugin

                        ExecuteMultipleRequest requestWithoutResults = new ExecuteMultipleRequest()
                        {
                            // Assign settings that define execution behavior: continue on error, return responses. 
                            Settings = new ExecuteMultipleSettings()
                            {
                                ContinueOnError = false,
                                ReturnResponses = false
                            },
                            // Create an empty organization request collection.
                            Requests = new OrganizationRequestCollection()
                        };

                        // Get the union of machines status log records and their matching flow machines
                        var uMachineStatuses = UpdatableMachineStatuses(currentUserService, machineIds);

                        DateTime currenUtcDT = DateTime.UtcNow;

                        int updateCount = 0;
                        int insertCount = 0;
                        int orphanCount = 0;
                        int notRegisteredCount = 0;
                        int offlineCount = 0;
                        int deletedCount = 0;

                        int maschineStatusCount = mStats.Count;

                        foreach (DataverseFlowMachine m in pagedMachines)
                        {
                            autocoe_MachineStatusLog newOrUpdatedMachineStatus;

                            // Check if we have already a machine status log entry for this machine
                            autocoe_MachineStatusLog lastMachineStatus = uMachineStatuses.Entities.FirstOrDefault(ums => Guid.Parse(ums.GetAttributeValue<string>("autocoe_machineid")) == Guid.Parse(m.flowmachineid)) as autocoe_MachineStatusLog;

                            // Get the live status of the currently processed machine
                            MachineStatus liveMachineStatus = mStats.FirstOrDefault(s => Guid.Parse(s.machineId) == Guid.Parse(m.flowmachineid));

                            // Get the Dataverse OptionSet value for the string status
                            var onlineStatus = OptionSetHelper.GetOnlineStatusOptionSetValue(liveMachineStatus.status);

                            if (liveMachineStatus.status == "Offline")
                                offlineCount++;

                            if (liveMachineStatus.status.Equals("NotRegistered"))
                                notRegisteredCount++;

                            // If we have a lastMachineStatus than this is subject to an update
                            if (lastMachineStatus != null)
                                newOrUpdatedMachineStatus = new autocoe_MachineStatusLog() { Id = lastMachineStatus.Id };
                            else
                                // Otherwise we have a new machine status here
                                newOrUpdatedMachineStatus = new autocoe_MachineStatusLog();

                            newOrUpdatedMachineStatus.autocoe_Name = m.name;
                            newOrUpdatedMachineStatus.autocoe_MachineId = m.flowmachineid;
                            newOrUpdatedMachineStatus.autocoe_OnlineStatus = onlineStatus;
                            newOrUpdatedMachineStatus.autocoe_LastStatusUpdateTime = currenUtcDT;
                            newOrUpdatedMachineStatus.autocoe_ErrorInfo = liveMachineStatus.errorInfo != null ? PluginUtility.Serialize(liveMachineStatus.errorInfo) : "";
                            newOrUpdatedMachineStatus.autocoe_EnvironmentUniqueName = localContext.PluginExecutionContext.OrganizationName;
                            newOrUpdatedMachineStatus.autocoe_InitiatingUserId = localContext.PluginExecutionContext.InitiatingUserId.ToString();

                            if (lastMachineStatus != null)
                            {
                                // Check if the machine status has changes since the last processing
                                if (!lastMachineStatus.FormattedValues["autocoe_onlinestatus"].ToString().Equals(liveMachineStatus.status))
                                {
                                    // If the machine was NOT Online before just make sure it is activated again from a Dataverse record perspective
                                    if (liveMachineStatus.status.Equals("Online"))
                                    {
                                        // Re-activate the record
                                        newOrUpdatedMachineStatus.statecode = autocoe_MachineStatusLogState.Active;
                                        newOrUpdatedMachineStatus.statuscode = autocoe_machinestatuslog_statuscode.Active;
                                    }

                                    // Add to the list of UpdateRequests
                                    requestWithoutResults.Requests.Add(new UpdateRequest { Target = newOrUpdatedMachineStatus });
                                    updateCount++;
                                }
                            }
                            else
                            {
                                // Add to the list of InsertRequests
                                requestWithoutResults.Requests.Add(new CreateRequest { Target = newOrUpdatedMachineStatus });
                                insertCount++;
                            }
                        }

                        // Remove or inactivate Machine Status Records for which no Flow Machine is available anymore
                        if (lastBatch && doAnOrphanedMachineCheck && !String.IsNullOrEmpty(context.InputParameters["AllFlowMachines"].ToString()))
                        {
                            // This parameter is only supplied on the last batch and includes a list of all Flow Machines so we can do a delta check
                            var allMachines = PluginUtility
                                .Deserialize<List<DataverseFlowMachine>>((context.InputParameters["AllFlowMachines"] as string));

                            // Get the outer joined machines that are no longer registered on the backend service
                            var orphanedMachineStatuses = OrphanedMachineStatuses(currentUserService, allMachines.Select(m => m.flowmachineid.ToString()).ToArray());

                            // Insert the new Flow Machine Statuses 
                            foreach (autocoe_MachineStatusLog orphanedMachineStatus in orphanedMachineStatuses.Entities)
                            {
                                autocoe_MachineStatusLog machineStatus = new autocoe_MachineStatusLog() { Id = orphanedMachineStatus.Id };

                                if (deleteOrphanedMachineStatuses)
                                {
                                    // Delete the record
                                    requestWithoutResults.Requests.Add(new DeleteRequest { Target = machineStatus.ToEntityReference() });

                                    deletedCount++;
                                }
                                else
                                {
                                    // Only update newly orphaned machines
                                    if (orphanedMachineStatus.statecode.Equals(autocoe_MachineStatusLogState.Active))
                                    {
                                        // Inactivate the record
                                        machineStatus.statecode = autocoe_MachineStatusLogState.Inactive;
                                        machineStatus.statuscode = autocoe_machinestatuslog_statuscode.Inactive;
                                        machineStatus.autocoe_OnlineStatus = new OptionSetValue((Int32)autocoe_MachineStatus_Enum.Offline);

                                        requestWithoutResults.Requests.Add(new UpdateRequest { Target = machineStatus });
                                    }
                                    // Always report back the amount of orphaned machines
                                    orphanCount++;
                                }
                            }
                        }
                        try
                        {

                            if (orphanCount > 0 || insertCount > 0 || updateCount > 0 || deletedCount > 0)
                            {
                                // Same explanation as above (around line 154)
                                // Even though product guidance for plugins is to not use ExecuteMultipleRequests,
                                // we're ignoring this here because of the large amount of API calls this would produce.
                                // Power Platform solution checker violation rule will fire when you run the checker: il-avoid-batch-plugin
                                // See more here: https://docs.microsoft.com/en-us/powerapps/developer/data-platform/best-practices/business-logic/avoid-batch-requests-plugin

                                ExecuteMultipleResponse responseWithoutResults =
                                    (ExecuteMultipleResponse)currentUserService.Execute(requestWithoutResults);

                                // If we have an error than the count would be > 0
                                if (responseWithoutResults.Responses.Count > 0)
                                {
                                    foreach (var response in responseWithoutResults.Responses)
                                    {
                                        if (response.Fault != null)
                                        {
                                            tracingService.Trace($"A fault in Plugin Automation CoE - UpdateMachineStatuses occurred when upserting multiple records in '{requestWithoutResults.Requests[response.RequestIndex]}' request, at index {response.RequestIndex} in the request collection with a fault message: {response.Fault}");
                                            throw new InvalidPluginExecutionException($"A fault in Plugin Automation CoE - UpdateMachineStatuses occurred when upserting multiple records in '{requestWithoutResults.Requests[response.RequestIndex]}' request, at index {response.RequestIndex} in the request collection with a fault message: {response.Fault}");
                                        }
                                    }
                                }
                            }
                        }
                        catch (FaultException<OrganizationServiceFault> ex)
                        {
                            tracingService.Trace($"The application terminated with an error.");
                            tracingService.Trace($"Timestamp: {ex.Detail.Timestamp}");
                            tracingService.Trace($"Code: {ex.Detail.ErrorCode}");
                            tracingService.Trace($"Message: {ex.Detail.Message}");
                        }
                        catch (System.TimeoutException ex)
                        {
                            tracingService.Trace($"The plugin terminated with a timeout exception.");
                            tracingService.Trace($"Message: {ex.Message}");
                            tracingService.Trace($"Stack Trace: {ex.StackTrace}");
                        }
                        catch (System.Exception ex)
                        {
                            tracingService.Trace($"The plugin terminated with an error. {ex.Message}");

                            // Display the details of the inner exception.
                            if (ex.InnerException != null)
                            {
                                FaultException<OrganizationServiceFault> fe = ex.InnerException
                                    as FaultException<OrganizationServiceFault>;
                                if (fe != null)
                                {
                                    tracingService.Trace($"Timestamp: {fe.Detail.Timestamp}");
                                    tracingService.Trace($"Code: {fe.Detail.ErrorCode}");
                                    tracingService.Trace($"Message: {fe.Detail.Message}");
                                    tracingService.Trace($"Trace: {fe.Detail.TraceText}");
                                }
                            }
                        }
                        // Stop the timer
                        watch.Stop();

                        // Custom API Response Parameters that are returned back to the calling cloud flow 
                        context.OutputParameters["ProcessingTimeInSeconds"] = (int)watch.Elapsed.TotalSeconds;
                        context.OutputParameters["EnvironmentUniqueName"] = localContext.PluginExecutionContext.OrganizationName;
                        context.OutputParameters["MachineInsertCount"] = insertCount;
                        context.OutputParameters["MachineUpdateCount"] = updateCount;
                        context.OutputParameters["MachineOrphanCount"] = orphanCount;
                        context.OutputParameters["MachineOfflineCount"] = offlineCount;
                        context.OutputParameters["MachineNotRegisteredCount"] = notRegisteredCount;
                        context.OutputParameters["MachineDeleteCount"] = deletedCount;
                        context.OutputParameters["MachineStatusCount"] = maschineStatusCount;

                    }
                    else
                    {
                        tracingService.Trace($"An error occurred executing Plugin Automation CoE - UpdateDesktopFlowMachineStatusLogs - at least one of the parameters is less than 0 BatchSize: {batchSize} & BatchNumber: {batchNumber} Input ");
                        throw new InvalidPluginExecutionException($"An error occurred executing Plugin Automation CoE - UpdateDesktopFlowMachineStatusLogs - at least one of the parameters is less than 0 BatchSize: {batchSize} & BatchNumber: {batchNumber} Input ");
                    }
                }
                else
                {
                    tracingService.Trace($"Plugin Automation CoE - UpdateDesktopFlowMachineStatusLogs is not associated with the expected message or is not registered for the main operation. Stage: {context.Stage} and PlugInMessageName: {context.MessageName}");
                }
            }
            //Only throw an InvalidPluginExecutionException.Please Refer https://go.microsoft.com/fwlink/?linkid=2153829.
            catch (Exception ex)
            {
                tracingService?.Trace($"An error occurred executing Plugin Automation CoE - UpdateDesktopFlowMachineStatusLogs  : {ex.ToString()}");
                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    FaultException<OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<OrganizationServiceFault>;
                    if (fe != null)
                    {
                        tracingService.Trace($"Timestamp: {fe.Detail.Timestamp}");
                        tracingService.Trace($"Code: {fe.Detail.ErrorCode}");
                        tracingService.Trace($"Message: {fe.Detail.Message}");
                        tracingService.Trace($"Trace: {fe.Detail.TraceText}");
                    }
                }
                throw new InvalidPluginExecutionException("An error occurred executing Plugin Automation CoE - UpdateDesktopFlowMachineStatusLogs.", ex);
            }
        }

        /// <summary>
        /// This function retrieves a list of machine statuses with a max. batch-size of 20. 
        /// Note that the current version of the undocumented BatchGetFlowMachineStatus API requires the 'machineIds' property within the 
        /// POST body to be specified in escaped format e.g.:
        /// {
        ///  "version": "2",
        ///  "machineIds": "[\"a6ddb58a-9d98-ec11-b401-000d3a83c4a0\",\"a6ddb58a-9d98-ec11-b401-000d3a83c4b0\"]"
        ///  }
        /// </summary>
        /// <param name="currentUserService"></param>
        /// <param name="nextBatch"></param>
        /// <returns>A string array with the machine ids, online status and potential error(S)</returns>
        private string GetLiveMachineStatus(IOrganizationService currentUserService, string[] nextBatch)
        {

            // Get the machine status from the unbound action / API BatchGetFlowMachineStatus                    
            var unboundActionRequest = new OrganizationRequest("BatchGetFlowMachineStatus");
            unboundActionRequest.Parameters.Add("version", "2");
            unboundActionRequest.Parameters.Add("machineIds", PluginUtility.Serialize(nextBatch));

            List<MachineStatus> machineStats = new List<MachineStatus>();

            try
            {
                var response = currentUserService.Execute(unboundActionRequest);
                var results = response.Results.Values.FirstOrDefault().ToString();

                return results;
            }
            catch (Exception ex)
            {
                // In case of an exception, we can check if the error is due to a non-existing machine for a supplied machineId.
                // This could happen if one or more machines have been removed during a running machine status update.
                // If this is true(e.g. if we have an error message that contains the following text, then we call the same GetLiveMachineStatus recursively,
                // until all invalid machineStatusIds have been removed from the nextBatch variable.
                string searchTerm = "flowmachine with id = ";

                if (ex.Message.ToLower().Contains(searchTerm))
                {
                    // Extract failing machineId from error message
                    string guidStr = ex.Message.Substring(ex.Message.ToLower().IndexOf(searchTerm) + searchTerm.Length, 36);

                    // Create a new array without the failing machineId
                    string[] newArray = nextBatch.Where(s => !s.Equals(guidStr, StringComparison.OrdinalIgnoreCase)).ToArray();

                    // Call the same function recursively until all invalid machineId's are removed
                    return GetLiveMachineStatus(currentUserService, newArray);
                }
                return "[]";
            }
        }

        /// <summary>
        /// Retrieves all machine status log records that are found in the list of supplied machineIds
        /// </summary>
        /// <param name="currentUserService"></param>
        /// <param name="machineIds"></param>
        /// <returns></returns>
        private static EntityCollection UpdatableMachineStatuses(IOrganizationService currentUserService, string[] machineIds)
        {
            QueryExpression query = new QueryExpression(autocoe_MachineStatusLog.EntityLogicalName);
            query.ColumnSet.AddColumns("autocoe_environmentuniquename",
                "autocoe_laststatusupdatetime",
                "autocoe_machineid",
                "autocoe_onlinestatus");
            query.AddOrder("autocoe_name", OrderType.Ascending);
            query.Criteria.AddCondition("autocoe_machineid", ConditionOperator.In, machineIds); // InnerJoin

            EntityCollection updatableMachineStatusRecords = currentUserService.RetrieveMultiple(query);

            return updatableMachineStatusRecords;
        }

        /// <summary>
        /// Retrieves all machine status log records that are NOT found in the overall Flow Machine list in Dataverse
        /// </summary>
        /// <param name="currentUserService"></param>
        /// <param name="allMachineIds"></param>
        /// <returns></returns>
        private static EntityCollection OrphanedMachineStatuses(IOrganizationService currentUserService, string[] allMachineIds)
        {
            QueryExpression query = new QueryExpression(autocoe_MachineStatusLog.EntityLogicalName);
            query.ColumnSet.AddColumns("autocoe_machineid", "statecode", "statuscode");
            query.Criteria.AddCondition("autocoe_machineid", ConditionOperator.NotIn, allMachineIds); // Kind of OuterJoin

            EntityCollection orphanedMachineStatusRecords = currentUserService.RetrieveMultiple(query);

            return orphanedMachineStatusRecords;
        }
    }
}
