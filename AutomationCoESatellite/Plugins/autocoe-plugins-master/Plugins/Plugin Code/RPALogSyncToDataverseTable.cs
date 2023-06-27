namespace AutoCoE.Extensibility.Plugins
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.Json;
    using AutoCoE.Extensibility.Plugins.DataModel;
    using AutoCoE.Extensibility.Plugins.PluginHelper;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Query;

    /// <summary>
    /// RPALogSyncToDataverseTable Plugin.
    /// </summary>    
    public class RPALogSyncToDataverseTable : PluginBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RPALogSyncToDataverseTable"/> class.
        /// </summary>
        /// <param name="unsecure">Contains public (unsecured) configuration information.</param>
        /// <param name="secure">Contains non-public (secured) configuration information. 
        /// When using Microsoft Dynamics 365 for Outlook with Offline Access, 
        /// the secure string is not passed to a plug-in that executes while the client is offline.</param>
        public RPALogSyncToDataverseTable(string unsecure, string secure)
            : base(typeof(RPALogSyncToDataverseTable))
        {
        }

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
        protected override void ExecuteDataversePlugin(ILocalPluginContext localPluginContext)
        {
            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            var context = localPluginContext.PluginExecutionContext;
            // Obtain the organization service reference for web service calls.  
            IOrganizationService currentUserService = localPluginContext.PluginUserService;

            // Obtain the tracing service
            ITracingService tracingService = localPluginContext.TracingService;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                // PostOperation stage                    
                if (context.MessageName.ToLower().Equals("autocoe_rpalogsynctodataversetable") && context.Stage.Equals(30))
                {
                    try
                    {
                        if (!context.InputParameters.Contains("FlowSessionLogId"))
                        {
                            throw new InvalidPluginExecutionException($"We couldn't find a valid Flow Session Log Id in the context.InputParameters Collection.");
                        }

                        autocoe_FlowSessionLog flowSessionLog = currentUserService.Retrieve(autocoe_FlowSessionLog.EntityLogicalName, Guid.Parse(context.InputParameters["FlowSessionLogId"].ToString()), new ColumnSet(true)).ToEntity<autocoe_FlowSessionLog>();

                        if (flowSessionLog == null)
                        {
                            throw new InvalidPluginExecutionException($"We couldn't find a valid Flow Session Log for Id: {context.InputParameters["FlowSessionLogId"]}.");
                        }

                        tracingService.Trace($"Automation CoE - RPALogSyncToDataverseTable - Flow Session Log Id: {flowSessionLog.Id} ");

                        if (!string.IsNullOrWhiteSpace(flowSessionLog.autocoe_FlowSessionId))
                        {
                            var cfRemediationDetails = flowSessionLog.Contains("autocoe_cloudflowerrorremediationdetails") ? PluginUtility.Deserialize<CloudFlowErrorRemidiationDetails>(flowSessionLog["autocoe_cloudflowerrorremediationdetails"].ToString()) : null;

                            if (flowSessionLog.autocoe_DesktopFlowStatus.Equals("Failed"))
                            {
                                // Sample content "{\"actions\":[{\"name\":\"Display select file dialog\",\"systemActionName\":\"SelectFileDialog\",\"systemModuleName\":\"Display\",\"localizedModuleName\":\"Message boxes\",\"startTime\":\"2023-02-20T10:44:35.7885613Z\",\"endTime\":\"2023-02-20T11:01:19.9636296Z\",\"index\":2,\"functionName\":\"main\",\"insideErrorHandling\":false,\"status\":\"Succeeded\",\"inputs\":{\"allowMultiple\":{\"localizedName\":\"Allow multiple selection\",\"value\":\"False\",\"variableName\":\"\"},\"title\":{\"localizedName\":\"Dialog title\",\"value\":\"Select the excel file to extract table from...\",\"variableName\":\"\"},\"fileFilter\":{\"localizedName\":\"File filter\",\"value\":\"*.xls*\",\"variableName\":\"\"},\"isTopMost\":{\"localizedName\":\"Keep file selection dialog always on top\",\"value\":\"True\",\"variableName\":\"\"},\"checkIfFileExists\":{\"localizedName\":\"Check if file exists\",\"value\":\"True\",\"variableName\":\"\"}},\"outputs\":{\"selectedFile\":{\"localizedName\":\"Selected file\",\"value\":\"\",\"variableName\":\"SelectedFile\"},\"buttonPressed\":{\"localizedName\":\"Button pressed\",\"value\":\"Cancel\",\"variableName\":\"ButtonPressed\"}}},{\"name\":\"If\",\"systemActionName\":\"If\",\"systemModuleName\":\"Conditionals\",\"localizedModuleName\":\"Conditionals\",\"startTime\":\"2023-02-20T11:01:20.0370639Z\",\"endTime\":\"2023-02-20T11:01:20.0478908Z\",\"index\":4,\"functionName\":\"main\",\"insideErrorHandling\":false,\"status\":\"Succeeded\",\"inputs\":{\"expression\":{\"localizedName\":\"Condition\",\"value\":\"False\",\"variableName\":\"\"}},\"outputs\":{}}],\"childFlowsLogStatus\":\"Default\"}";
                                string flowContext = PluginUtility.ExtractAdditionalContext(currentUserService, Guid.Parse(flowSessionLog.autocoe_FlowSessionId));
                                PADActionLog padActions = PluginUtility.Deserialize<PADActionLog>(flowContext);

                                // Max log entry size seems to be 10k rows, so no need to add so many rows if the action that threw the error is not included anyhow
                                if (padActions.actions.Where(e => e.status == "Failed").Count() > 0)
                                {
                                    // var actionList = ((JArray)JObject
                                    //    .Parse(flowContext)["actions"])
                                    //    .Where(a => a["status"].ToString() == "Failed")
                                    //    .FirstOrDefault();

                                    // string desinput = JsonConvert.DeserializeObject(actionList["inputs"].ToString(Newtonsoft.Json.Formatting.Indented)).ToString();
                                    //// string desoutput = JsonConvert.DeserializeObject(actionList["outputs"].ToString(Newtonsoft.Json.Formatting.Indented)).ToString();

                                    string desinput = this.ParseInputandOutput(flowContext, "inputs");
                                    string desoutput = this.ParseInputandOutput(flowContext, "outputs");

                                    var failingAction = padActions.actions.Where(e => e.status == "Failed").First();
                                    flowSessionLog.autocoe_FailingDesktopFlowModule = failingAction.localizedModuleName;
                                    flowSessionLog.autocoe_FailingDesktopFlowFunction = failingAction.functionName;
                                    flowSessionLog.autocoe_FailingDesktopFlowAction = failingAction.systemActionName;
                                    flowSessionLog.autocoe_DesktopFlowActionErrorCode = failingAction.error.code;
                                    flowSessionLog.autocoe_DesktopFlowActionErrorMessage = failingAction.error.message;
                                    flowSessionLog.autocoe_ActionInput = desinput;
                                    flowSessionLog.autocoe_ActionOutput = desoutput;

                                    currentUserService.Update(flowSessionLog);
                                }
                                else
                                {
                                    if (padActions.actions.Count > 10000)
                                    {
                                        flowSessionLog.autocoe_DesktopFlowActionErrorMessage = "!-->>> The desktop flow error occurred after reaching the current max action log row size (10k) supported by the PAD log mechanism. Therefore, no action error details are included in the logs. <<<--!";
                                    }

                                    currentUserService.Update(flowSessionLog);
                                }
                            }

                            watch.Stop();
                        }
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace($"Automation CoE - RPALogSyncToDataverseTable Exception: {ex.ToString()}");
                        throw new InvalidPluginExecutionException("An error occurred in RPALogSyncToDataverseTable.", ex);
                    }
                }
                else
                {
                    tracingService.Trace("Automation CoE - RPALogSyncToDataverseTable plug-in is not associated with the expected message or is not registered for the main operation.");
                }
            }
            catch (Exception ex)
            {
                tracingService?.Trace("An error occurred executing Plugin AutoCoE.Extensibility.Plugins.RPALogSyncToDataverseTable : {0}", ex.ToString());
                throw new InvalidPluginExecutionException("An error occurred executing Plugin AutoCoE.Extensibility.Plugins.RPALogSyncToDataverseTable .", ex);
            }
        }

        /// <summary>
        /// Parses 'flowContextDetails' and return 'RawText' of 'input' and 'output' parameters.
        /// </summary>
        /// <param name="flowContextDetails">Flow Context Details</param>
        /// <param name="propertyName">Property Name</param>
        /// <returns>Raw Text of Parameter</returns>
        private string ParseInputandOutput(string flowContextDetails, string propertyName)
        {
            StringBuilder sbrRawText = new StringBuilder();
            JsonDocument doc = JsonDocument.Parse(flowContextDetails);
            JsonElement actions = doc.RootElement.GetProperty("actions");

            foreach (JsonElement action in actions.EnumerateArray())
            {
                if (action.GetProperty("status").GetString() == "Failed")
                {
                    JsonElement propertyNodes = action.GetProperty(propertyName);
                    sbrRawText.AppendLine(propertyNodes.ToString());
                }
            }

            return sbrRawText.ToString();
        }
    }
}