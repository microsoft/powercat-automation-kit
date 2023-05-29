
//    MIT License

//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the "Software"), to deal
//    in the Software without restriction, including without limitation the rights
//    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the Software is
//    furnished to do so, subject to the following conditions:

//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.

//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using AutoCoE.Extensibility.Plugins.PluginHelper;
using System.Runtime.Remoting.Services;

namespace AutoCoE.Extensibility.Plugins
{
    /// <summary>
    /// GetDataverseSolutionArtifacts Plugin to featch solution components to meter.
    /// </summary>   
    public class GetDataverseSolutionArtifacts : PluginBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDataverseSolutionArtifacts"/> class.
        /// </summary>
        /// <param name="unsecureConfiguration">Contains public (unsecured) configuration information.</param>
        /// <param name="secureConfiguration">Contains non-public (secured) configuration information. 
        /// When using Microsoft Dynamics 365 for Outlook with Offline Access, 
        /// the secure string is not passed to a plug-in that executes while the client is offline.</param>
        public GetDataverseSolutionArtifacts(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(GetDataverseSolutionArtifacts))
        {
        }
        /// <summary>
        /// Main entry point for he business logic that the plug-in is to execute.
        /// </summary>
        /// <param name="localPluginContext">The <see cref="LocalPluginContext"/> which contains the
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
        /// 
        protected override void ExecuteCdsPlugin(ILocalPluginContext localPluginContext)
        {
            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            // Obtain the tracing service
            ITracingService tracingService = localPluginContext.TracingService;

            // Get the organizasion service to retrieve the environment variable for user id to impersonate
            var organizationService = localPluginContext.CurrentUserService;

            var context = localPluginContext.PluginExecutionContext;
            var solutionid = new Guid();

            // Getting user id to impersonate to fetch solution components
            var systemUserIdToImpersonate = GetAzureAppUserIdToImpersonate(organizationService, tracingService);

            //if (string.IsNullOrWhiteSpace(systemUserIdToImpersonate.ToString()))
            //    tracingService.Trace("Application User id not found. Please verify respective environment variable");

            tracingService.Trace("Application User id found and User id is =" + systemUserIdToImpersonate.ToString());

            // Create the organizasion service with using of impersonate the user
            var serviceFactory = (IOrganizationServiceFactory)localPluginContext.ServiceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(systemUserIdToImpersonate);

            if (service != null)
                tracingService.Trace("Organization service is created sucessfully with user id " + systemUserIdToImpersonate.ToString());

            // validating solution id input param 
            if (!context.InputParameters.Contains("SolutionManagerSolutionId"))
                throw new InvalidPluginExecutionException($"We couldn't find a valid Solution Id in the context.InputParameters Collection.");

            solutionid = Guid.Parse(context.InputParameters["SolutionManagerSolutionId"].ToString());

            // Getting solution components for given solution id as input param
            var SolutionArtifacts = GetSolutoinArtifacts(service, solutionid, tracingService);

            if (SolutionArtifacts.Entities.Count > 0)
            {
                tracingService.Trace("Solution Artifacts retrived successfully and count=" + SolutionArtifacts.Entities.Count);
            }
            else
            {
                tracingService.Trace("Solution Artifacts not found for given solution " + solutionid);
            }

            context.OutputParameters["SolutionArtifacts"] = SolutionArtifacts;
        }

        /// <summary>
        /// Retriving of solution components from table msdyn_solutioncomponentsummary for given solution id.
        /// using of iorganization service, wihich is created / impersonated of having respective permissions on table msdyn_solutioncomponentsummary
        /// </summary>
        /// <param name="service"></param>
        /// <param name="SolutionId"></param>
        /// <param name="TracingService"></param>
        /// <returns></returns>
        private static EntityCollection GetSolutoinArtifacts(IOrganizationService service, Guid SolutionId, ITracingService TracingService)
        {
            var query = new QueryExpression("msdyn_solutioncomponentsummary")
            {
                ColumnSet = new ColumnSet("msdyn_schemaname", "msdyn_modifiedon", "msdyn_createdon", "msdyn_iscustomizable", "msdyn_ismanaged", "msdyn_solutionid", "msdyn_name", "msdyn_displayname", "msdyn_objecttypecode", "msdyn_componenttype", "msdyn_componenttypename", "msdyn_componentlogicalname", "msdyn_primaryidattribute", "msdyn_total", "msdyn_owner", "msdyn_connectorinternalid", "msdyn_workflowcategoryname", "msdyn_subtype", "msdyn_workflowcategory", "msdyn_workflowidunique", "msdyn_description", "msdyn_objectid"),
                Criteria = new FilterExpression()
                {
                    Conditions =
                    {
                        new ConditionExpression("msdyn_solutionid", ConditionOperator.Equal, SolutionId) // fetching solution components
                    }
                }
            };

            EntityCollection result= new EntityCollection();

            try
            {
                 result = service.RetrieveMultiple(query);
            }
            catch (Exception ex)
            {

                throw new InvalidPluginExecutionException($"We couldn't able to retrive solution components from table 'msdyn_solutioncomponentsummary'. Original exception message:" + ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Retriving user id from environment variable autocoe_SolutionManagerArtifactsReadUserId.
        /// Later this user id will be used to impersonate /create iorganigation service to retive solution components to meter the solution
        /// </summary>
        /// <param name="organizationService"></param>
        /// <param name="TracingService"></param>
        /// <returns></returns>
        private static Guid GetAzureAppUserIdToImpersonate(IOrganizationService organizationService,ITracingService TracingService)
        {
            var environmentVariableQuery = new QueryExpression("environmentvariabledefinition")
            {
                ColumnSet = new ColumnSet("environmentvariabledefinitionid"),
                LinkEntities =
                        {
                            new LinkEntity
                            {
                                JoinOperator = JoinOperator.LeftOuter,
                                LinkFromEntityName = "environmentvariabledefinition",
                                LinkFromAttributeName = "environmentvariabledefinitionid",
                                LinkToEntityName = "environmentvariablevalue",
                                LinkToAttributeName = "environmentvariabledefinitionid",
                                Columns = new ColumnSet("value"),
                                EntityAlias = "v"
                            }
                        },
                Criteria = new FilterExpression()
                {
                    Conditions =
                    {
                        new ConditionExpression("schemaname", ConditionOperator.Equal, "autocoe_SolutionManagerArtifactsReadUserId")
                    }
                }
            };

            var systemUserId = Guid.Empty;

            try
            {
                var environmentVariables = organizationService.RetrieveMultiple(environmentVariableQuery);

                if (environmentVariables.Entities.Count >0)
                {
                     systemUserId = Guid.Parse(environmentVariables.Entities[0].GetAttributeValue<AliasedValue>("v.value").Value.ToString());
                }
                else
                {
                    TracingService.Trace("User id not found from environment variable 'autocoe_SolutionManagerArtifactsReadUserId'. Please verify and update with respective user id");
                    throw new InvalidPluginExecutionException($"The environment variable 'autocoe_SolutionManagerArtifactsReadUserId' is not found.");
                }

            }
            catch (Exception ex)
            {
                TracingService.Trace("Application User id not found. Please verify respective environment variable");
                throw new InvalidPluginExecutionException($"We couldn't able to retrive user id from environment variable 'autocoe_SolutionManagerArtifactsReadUserId'. Original exception message:" + ex.Message);
            }
           
            return systemUserId;
        }
    }
}