using System;
using System.ComponentModel.Composition;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;
using Microsoft.Xrm.Sdk;
using System.Collections.Specialized;
using System.Reflection;
using System.IO;
using System.Linq;
using Microsoft.Xrm.Sdk.Messages;
using System.Globalization;

namespace AutomationKIT
{
    /// <summary>
    /// Import package starter frame.
    /// </summary>
    [Export(typeof(IImportExtensions))]
    public class PackageImportExtension : ImportExtension
    {
        #region Metadata

        /// <summary>
        /// Folder name where package assets are located in the final output package zip.
        /// </summary>
        public override string GetImportPackageDataFolderName => "PkgAssets";

        /// <summary>
        /// Name of the Import Package to Use
        /// </summary>
        /// <param name="plural">if true, return plural version</param>
        public override string GetNameOfImport(bool plural) => "AutomationKIT For Main environment";

        /// <summary>
        /// Long name of the Import Package.
        /// </summary>
        public override string GetLongNameOfImport => "Automation KIT for Main environment";

        /// <summary>
        /// Description of the package, used in the package selection UI
        /// </summary>
        public override string GetImportPackageDescriptionText => "Automation kit provides a set of templates and tools beyond the core Admin controls in the product for organizations to customize how they roll out and manage Power Platform Automation solutions for main environment.";

        
        private bool NeedToImportMainSolution = false;        
        private bool ImportSampleData = false;
        private bool NeedToActivateApprovalFlow = false;
        private bool NeedToActivateROIFlow = false;
        private bool NeedToActivateSyncFlow = false;
        private string ProjectAdminUsers = string.Empty;
        private string ProjectContributors = string.Empty;
        private string ProjectViewers = string.Empty;
        private string ProjectBusinessOwner = string.Empty;        
        #endregion

        #region Default data
        private string const_Approval_Flow_Name;
        private string const_Calc_ROI_Flow_Name;
        private string const_Sync_Env_Flow_Name;

        private string const_Security_Name_Project_Admin;
        private string const_Security_Name_Project_Contributor;
        private string const_Security_Name_Project_Viewer;

        private string const_Admin_Email_To_Find;
        private string const_Canvas_App_Name_For_Projects;

        private int const_NoOfRecordsForBatchProcessing;

        #endregion

        /// <summary>
        /// Called to Initialize any functions in the Custom Extension.
        /// </summary>
        /// <see cref="ImportExtension.InitializeCustomExtension"/>
        public override void InitializeCustomExtension()
        {
            string strKey;
            string strValue;
                       
            PackageLog.Log("InitializeCustomExtension is started on " + DateTime.Now.ToString());

            const_Approval_Flow_Name = AutomationKIT_Main.AutomationKit_Main.Default.Flow_Name_Project_Approvals.ToString();
            const_Calc_ROI_Flow_Name = AutomationKIT_Main.AutomationKit_Main.Default.Flow_Name_Calculate_ROI.ToString();
            const_Sync_Env_Flow_Name = AutomationKIT_Main.AutomationKit_Main.Default.Flow_Name_Sync_Environments.ToString();

            const_Security_Name_Project_Admin = AutomationKIT_Main.AutomationKit_Main.Default.Security_Role_Project_Admin.ToString();
            const_Security_Name_Project_Contributor = AutomationKIT_Main.AutomationKit_Main.Default.Security_Role_Project_Contributor.ToString();
            const_Security_Name_Project_Viewer = AutomationKIT_Main.AutomationKit_Main.Default.Security_Role_Project_Viewer.ToString();

            const_Admin_Email_To_Find = AutomationKIT_Main.AutomationKit_Main.Default.Administrator_EmailId.ToString();
            const_Canvas_App_Name_For_Projects = AutomationKIT_Main.AutomationKit_Main.Default.Canvas_App_Project_Name.ToString();

            const_NoOfRecordsForBatchProcessing = (int) AutomationKIT_Main.AutomationKit_Main.Default.NoOfRecordsforBatchProcessing;

            try
            {
                if (RuntimeSettings != null)
                {
                    PackageLog.Log(string.Format("Runtime Settings populated.  Count = {0}", RuntimeSettings.Count));
                    foreach (var setting in RuntimeSettings)
                    {
                        strKey = setting.Key.ToString().Trim();
                        strValue = setting.Value.ToString().Trim();

                        PackageLog.Log(string.Format("Key={0} | Value={1}", strKey, strValue));

                        if (strKey.Contains("importconfigdata"))
                        {
                            bool.TryParse(strValue, out ImportSampleData);
                            DataImportBypass = (!ImportSampleData);
                            PackageLog.Log("ImportSampleData=" + ImportSampleData.ToString());
                            PackageLog.Log("DataImportBypass=" + DataImportBypass.ToString());
                        }
                        else if (strKey.Contains("installmainsolution"))
                        {
                            bool.TryParse(strValue, out NeedToImportMainSolution);
                            PackageLog.Log("NeedToImportMainSolution=" + NeedToImportMainSolution.ToString());
                        }                        
                        else if (strKey.Contains("activateapprovalflow"))
                        {
                            bool.TryParse(strValue, out NeedToActivateApprovalFlow);
                            PackageLog.Log("NeedToActivateApprovalFlow=" + NeedToActivateApprovalFlow.ToString());
                        }
                        else if (strKey.Contains("activateroiflow"))
                        {
                            bool.TryParse(strValue, out NeedToActivateROIFlow);
                            PackageLog.Log("NeedToActivateROIFlow=" + NeedToActivateROIFlow.ToString());
                        }
                        else if (strKey.Contains("activatesyncflow"))
                        {
                            bool.TryParse(strValue, out NeedToActivateSyncFlow);
                            PackageLog.Log("NeedToActivateSyncFlow=" + NeedToActivateSyncFlow.ToString());
                        }
                        else if (strKey.Contains("projectadminusers"))
                        {
                            ProjectAdminUsers = strValue.ToString();
                            PackageLog.Log("ProjectAdminUsers=" + ProjectAdminUsers);
                        }
                        else if (strKey.Contains("projectcontributors"))
                        {
                            ProjectContributors = strValue.ToString();
                            PackageLog.Log("ProjectContributors=" + ProjectContributors.ToString());
                        }
                        else if (strKey.Contains("projectviewers"))
                        {
                            ProjectViewers = strValue.ToString();
                            PackageLog.Log("ProjectViewers=" + ProjectViewers);
                        }
                        else if (strKey.Contains("businessowneremail"))
                        {
                            ProjectBusinessOwner = strValue.ToString();
                            PackageLog.Log("ProjectBusinessOwner=" + ProjectBusinessOwner);
                        }
                        
                    }

                }

            }
            catch (Exception ex)
            {
                PackageLog.Log("Error occured in while reading runtime settings. Please find the original exception details::" + ex.Message.ToString());
            }            
            PackageLog.Log("InitializeCustomExtension is completed on " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Called before the Main Import process begins, after solutions and data.
        /// </summary>
        /// <see cref="ImportExtension.BeforeImportStage"/>
        /// <returns></returns>
        public override bool BeforeImportStage()

        {
            PackageLog.Log("BeforeImportStage is completed on " + DateTime.Now.ToString());
            return true;
        }
        public override void PreSolutionImport(string solutionName, bool solutionOverwriteUnmanagedCustomizations, bool solutionPublishWorkflowsAndActivatePlugins, out bool overwriteUnmanagedCustomizations, out bool publishWorkflowsAndActivatePlugins)
        {

            PackageLog.Log("PreSolutionImport is started on " + DateTime.Now.ToString() + " with parameters::" + "solutionName=" + solutionName + ",solutionOverwriteUnmanagedCustomizations=" + solutionOverwriteUnmanagedCustomizations + ",solutionPublishWorkflowsAndActivatePlugins=" + solutionPublishWorkflowsAndActivatePlugins);

            base.PreSolutionImport(solutionName, solutionOverwriteUnmanagedCustomizations, solutionPublishWorkflowsAndActivatePlugins, out overwriteUnmanagedCustomizations, out publishWorkflowsAndActivatePlugins);

            PackageLog.Log("presolutionImport is completed on " + DateTime.Now.ToString() + ", DataImportBypass =" + DataImportBypass);

        }
        public override UserRequestedImportAction OverrideSolutionImportDecision(string solutionUniqueName, Version organizationVersion, Version packageSolutionVersion, Version inboundSolutionVersion, Version deployedSolutionVersion, ImportAction systemSelectedImportAction)
        {
            PackageLog.Log("OverrideSolutionImportDecision is started on " + DateTime.Now.ToString() + " with parameters:: solutionUniqueName=" + solutionUniqueName + ",organizationVersion=" + organizationVersion + ",packageSolutionVersion=" + packageSolutionVersion + ",inboundSolutionVersion=" + inboundSolutionVersion + ",deployedSolutionVersion=" + deployedSolutionVersion + ",systemSelectedImportAction=" + systemSelectedImportAction);

            if (NeedToImportMainSolution && solutionUniqueName.ToString().ToLower().Contains("main"))
                return UserRequestedImportAction.Default; //import main solution            
            else
                return UserRequestedImportAction.Skip;// skip other solutions
        }
        public override void RunSolutionUpgradeMigrationStep(string solutionName, string oldVersion, string newVersion, Guid oldSolutionId, Guid newSolutionId)
        {
            PackageLog.Log("RunsolutionUpgradeMigrationStep is started on " + DateTime.Now.ToString() + " with parameters:: solutionName=" + solutionName + ",oldVersion=" + oldVersion + ",newVersion=" + newVersion + ",oldSolutionId=" + oldSolutionId + ",newSolutionId=" + newSolutionId);

            base.RunSolutionUpgradeMigrationStep(solutionName, oldVersion, newVersion, oldSolutionId, newSolutionId);

            PackageLog.Log("RunsolutionUpgradeMigrationStep is completed on " + DateTime.Now.ToString());
        }
        public override bool AfterPrimaryImport()
        {
            PackageLog.Log("AfterPrimaryImport is started on " + DateTime.Now.ToString());
            /*
             Commenting for Fakeiteasy unit tests 
             ICrmServiceAdapter adapter = new CrmServiceAdapter(CrmSvc);
            TraceLoggerAdapter LoggerAdapter = new TraceLoggerAdapter(PackageLog);
           
            PackageExtensions packageExt = new PackageExtensions( adapter, LoggerAdapter);

            MainPackageExt mainpkgExt = new MainPackageExt((IPackageExtensions)packageExt);

            bool result;

            if (!string.IsNullOrEmpty(ProjectAdminUsers))            {

                result = mainpkgExt.AssignUsersToRole (ProjectAdminUsers, const_Security_Name_Project_Admin);                        
            }

            if (!string.IsNullOrEmpty(ProjectContributors))
            {
                result = mainpkgExt.AssignUsersToRole(ProjectContributors, const_Security_Name_Project_Contributor);
             
            }

            if (!string.IsNullOrEmpty(ProjectViewers))
            {
                result = mainpkgExt.AssignUsersToRole(ProjectViewers, const_Security_Name_Project_Viewer);
                
            }*/

            AssignUsersToRoles();
            ActivateDeActivateCloudFlows();
            UpdateBusinessOwnertoExistingProjects(ProjectBusinessOwner);
            UpdateConsoleConfigurations();
            InsertRecordstoDesktopFlowActionsTable();            
            InsertRecordstoFlowSessionTraceTable();
            PackageLog.Log("AfterPrimaryImport is completed on " + DateTime.Now.ToString());
            return true;
        }
        private Boolean ActivateDeActivateCloudFlows()
        {
            StringCollection flows = new StringCollection
            {
                const_Approval_Flow_Name,
                const_Calc_ROI_Flow_Name,
                const_Sync_Env_Flow_Name
            };
            bool result = false;

            foreach (string flow in flows)
            {
                if (flow == const_Approval_Flow_Name)
                {
                    result =ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateApprovalFlow);
                }
                else if (flow == const_Calc_ROI_Flow_Name)
                {
                    result= ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateROIFlow);
                }
                else if (flow == const_Sync_Env_Flow_Name)
                {
                    result= ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateSyncFlow);
                }
                else
                {
                    // other flows should be de-activated
                    result =ActivateDeActivateCloudFlow(flow.ToString(), false);
                }                
            }
            return result;
        }
        private Boolean ActivateDeActivateCloudFlow(string flowName, bool enableFlow)
        {
            PackageLog.Log("Started activation/de-activation for flow '" + flowName + "'");

            bool result ;

            var queryflow = new QueryExpression("workflow");
            queryflow.ColumnSet.AddColumns("statecode");
            queryflow.ColumnSet.AddColumns("statuscode");
            queryflow.ColumnSet.AddColumns("workflowid");
            queryflow.Criteria.AddCondition("name", ConditionOperator.Equal, flowName);
            try
            {
                var resultflow = CrmSvc.RetrieveMultiple(queryflow);
                var results = resultflow.Entities[0];

                if (enableFlow)
                {
                    results["statecode"] = new OptionSetValue(1);
                    results["statuscode"] = new OptionSetValue(2);
                }
                else
                {
                    results["statecode"] = new OptionSetValue(0);
                    results["statuscode"] = new OptionSetValue(1);
                }
                CrmSvc.Update(results);
                result = true;
            }
            catch (Exception err)
            {
                PackageLog.Log("Error occured while activating / de-activating the flow '" + flowName + "'. Error is " + err.Message.ToString());
                result = false;
            }
            
            PackageLog.Log("Completed activation/de-activation for flow '" + flowName + "' successfully.");
            return result;

        }        
        private Boolean AssignUsersToRoles()
        {
            bool result = false;

            if (!string.IsNullOrEmpty(ProjectAdminUsers))
            {
                
                result = AssignUsersToRole(ProjectAdminUsers, const_Security_Name_Project_Admin);
            }

            if (!string.IsNullOrEmpty(ProjectContributors))
            {
                
                result = AssignUsersToRole(ProjectContributors, const_Security_Name_Project_Contributor);
            }

            if (!string.IsNullOrEmpty(ProjectViewers))
            {
                result =AssignUsersToRole(ProjectViewers, const_Security_Name_Project_Viewer);
            }
            return result;
        }
        private Boolean AssignUsersToRole(string userEmailslist, string securityRole)
        {

            PackageLog.Log("Assigning users to security role '" + securityRole + "'");
            Guid roleid = Guid.Empty;

            bool result = false;

            if (!string.IsNullOrEmpty(userEmailslist) && !string.IsNullOrEmpty(securityRole))
            {
                // getting role id
                var queryRoles = new QueryExpression("role");
                queryRoles.ColumnSet.AddColumns("roleid");
                queryRoles.ColumnSet.AddColumns("name");
                queryRoles.Criteria.AddCondition("name", ConditionOperator.Equal, securityRole);
                try
                {
                    var resultroles = CrmSvc.RetrieveMultiple(queryRoles);
                    var results = resultroles.Entities[0];
                    roleid = (Guid)results["roleid"];
                }
                catch (Exception ex)
                {
                    PackageLog.Log("Unable to retrive role information for role '" + securityRole + "'. Erorr: " + ex.Message.ToString());
                    result = false;
                }

                string[] usersList = userEmailslist.Split(',');
                for (int i = 0; i < usersList.Length; i++)
                {     //getting user id              
                    var queryusers = new QueryExpression("systemuser");
                    queryusers.ColumnSet.AddColumns("systemuserid");
                    queryusers.Criteria.AddCondition("internalemailaddress", ConditionOperator.Equal, usersList[i].ToString());

                    var resultusers = CrmSvc.RetrieveMultiple(queryusers);
                    var results = resultusers.Entities[0];

                    Guid userid = (Guid)results["systemuserid"];

                    //assigning user to role
                    if (roleid != Guid.Empty && userid != Guid.Empty)
                    {
                        try
                        {
                            CrmSvc.DeleteEntityAssociation("systemuser", userid, "role", roleid, "systemuserroles_association");

                            CrmSvc.Associate("systemuser", userid, new Relationship("systemuserroles_association"), new EntityReferenceCollection() { new EntityReference("role", roleid) });
                            result = true;
                        }
                        catch (Exception ex)
                        {
                            PackageLog.Log("Unable to assign user '" + usersList[i].ToString() + "' to security role '" + securityRole + "'. Error:" + ex.Message.ToString());
                            result = false;
                        }
                    }

                }
            }

            PackageLog.Log("Completed of assigning roles");
            return result;
        }
        private Boolean UpdateBusinessOwnertoExistingProjects(string businessOwnerEmailId)
        {
            PackageLog.Log("Updating business owner to existing projects");
            bool result=false;

            if (!string.IsNullOrEmpty(businessOwnerEmailId))
            {
                // getting projects to update business owner emailid for old data
                var queryPrjects = new QueryExpression("autocoe_automationproject");
                queryPrjects.ColumnSet.AddColumns("autocoe_businessowneremail");
                queryPrjects.Criteria.AddCondition("autocoe_businessowneremail", ConditionOperator.Equal, const_Admin_Email_To_Find);
                try
                {
                    var resultProjects = CrmSvc.RetrieveMultiple(queryPrjects);
                    
                    if (resultProjects.Entities.Count > 0)
                    {
                        foreach (Entity proj in resultProjects.Entities)
                        {
                            proj["autocoe_businessowneremail"] = businessOwnerEmailId;

                            CrmSvc.Update(proj);
                            result = true;
                        }
                    }

                }
                catch (Exception ex)
                {
                    PackageLog.Log("Unable to update business owner for existing projects. Erorr: " + ex.Message.ToString());
                    result = false;
                }

                PackageLog.Log("Completed of updating business owner to existing projects");
            }
            return result;

        }
        private Boolean UpdateConsoleConfigurations()
        {
            PackageLog.Log("starting of Update console configurations ");
            bool result = false;
            
            if (!string.IsNullOrEmpty(const_Canvas_App_Name_For_Projects))
            {
                // getting canvas app details
                var querycanvasapps = new QueryExpression("canvasapp");
                querycanvasapps.ColumnSet.AddColumns("displayname");
                querycanvasapps.ColumnSet.AddColumns("appopenuri");
                querycanvasapps.ColumnSet.AddColumns("canvasappid");
                querycanvasapps.Criteria.AddCondition("displayname", ConditionOperator.Equal, const_Canvas_App_Name_For_Projects);
                try
                {                   
                    var resultapps = CrmSvc.RetrieveMultiple(querycanvasapps);
                    var results = resultapps[0];
                    string CanvasAPPId = results["canvasappid"].ToString();
                    string canvasAPPURL = results["appopenuri"].ToString();

                    //getting console config details
                    var queryconsoleApp = new QueryExpression("autocoe_consoleconfig");
                    queryconsoleApp.ColumnSet.AddColumns("autocoe_applink");
                    queryconsoleApp.ColumnSet.AddColumns("autocoe_appid");
                    queryconsoleApp.Criteria.AddCondition("autocoe_name", ConditionOperator.Equal, const_Canvas_App_Name_For_Projects);
                    //updating console config details with canvas app details
                    var resultconsoleApp = CrmSvc.RetrieveMultiple(queryconsoleApp);
                    if (resultconsoleApp.Entities.Count > 0)
                    {
                        var consoleapp = resultconsoleApp[0];
                        consoleapp["autocoe_appid"] = CanvasAPPId;
                        consoleapp["autocoe_applink"] = canvasAPPURL;
                        CrmSvc.Update(consoleapp);
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    PackageLog.Log("Unable to fetch canvas app details to update. Erorr: " + ex.Message.ToString());
                    result = false;
                }

                PackageLog.Log("Completed for Updating console configurations ");
            }
            return result;

        }
        private Boolean InsertRecordstoDesktopFlowActionsTable()
        {
            // check the record count for flow action table
            bool result = false;
            var queryflowAction = new QueryExpression("autocoe_desktopflowaction");
            var resultflowaction = CrmSvc.RetrieveMultiple(queryflowAction);
            PackageLog.Log("Existing records count in desktop flow actions=" + resultflowaction.Entities.Count);

            string csvpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\PkgAssets\\autocoe_desktopflowactions.csv";

            var EMflowRequests = new ExecuteMultipleRequest
            {
                Requests = new OrganizationRequestCollection(),
                Settings = new ExecuteMultipleSettings
                {
                    ContinueOnError = false,
                    ReturnResponses = false
                }
            };

            if (resultflowaction.Entities.Count == 0)
            {
                PackageLog.Log("Start- Updating of desktop flow action records on " + DateTime.Now);

                int columncount ;
                string[] lines = System.IO.File.ReadAllLines(csvpath);
                PackageLog.Log("Lines count:" + lines.Count());
                bool dlpImpact ;
                int rowcounter = 0;
                string actionName = "";
                foreach (string line in lines)
                {
                    if (rowcounter > 0)
                    {
                        string[] columns = line.Split(',');
                        columncount = 0;
                        var flowAction = new Entity("autocoe_desktopflowaction");
                        foreach (string column in columns)
                        {
                            if (columncount == 0)
                            {
                                flowAction.Attributes["autocoe_actionname"] = column;
                                actionName = column;
                            }
                            else if (columncount == 2)
                            {
                                bool.TryParse(column.Trim(), out dlpImpact);
                                flowAction.Attributes["autocoe_dlpsupport"] = dlpImpact;
                            }
                            else if (columncount == 4)
                                flowAction.Attributes["autocoe_moduledisplayname"] = column;
                            else if (columncount == 5)
                                flowAction.Attributes["autocoe_modulename"] = column;
                            else if (columncount == 6)
                                flowAction.Attributes["autocoe_modulesource"] = column;
                            else if (columncount == 7)
                                flowAction.Attributes["autocoe_selectorid"] = column;

                            columncount += 1;

                        }

                        EMflowRequests.Requests.Add(new UpsertRequest { Target = flowAction });

                        if (EMflowRequests.Requests.Count == const_NoOfRecordsForBatchProcessing)
                        {
                            try
                            {
                                PackageLog.Log("Inseting flowaciton for batch on " + DateTime.Now);
                                CrmSvc.Execute(EMflowRequests);
                                EMflowRequests.Requests.Clear();
                                result = true;
                            }
                            catch (Exception ex)
                            {
                                PackageLog.Log("unable to insert fllw session trace record for " + actionName + "Error=" + ex.Message);
                                result = false;

                            }

                        }
                        
                    }
                    rowcounter += 1;
                }

                if (EMflowRequests.Requests.Count > 0)
                {
                    CrmSvc.Execute(EMflowRequests);
                }
                PackageLog.Log("Completed - Updating of desktop flow action records ");

            }
            return result;

        }
        private Boolean InsertRecordstoFlowSessionTraceTable()
        {
            // check the record count for flow session trace table
            bool result ;
            var queryflowsession = new QueryExpression("autocoe_flowsessiontrace");
            var resultflowaction = CrmSvc.RetrieveMultiple(queryflowsession);
            PackageLog.Log("Existing records count in flow session trace table =" + resultflowaction.Entities.Count);

            string csvpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\PkgAssets\\autocoe_flowsessiontraces.csv";

            DateTime DTcompletedon;

            DateTime DTstartedon;

            var EMRequests = new ExecuteMultipleRequest
            {
                Requests = new OrganizationRequestCollection(),
                Settings = new ExecuteMultipleSettings
                {
                    ContinueOnError = false,
                    ReturnResponses = false
                }
            };            

            if (resultflowaction.Entities.Count == 0 && ImportSampleData)
            {
                PackageLog.Log("Start- Updating of flow session trace records on " + DateTime.Now.ToString());

                int columncount;
                string[] lines = System.IO.File.ReadAllLines(csvpath);
                PackageLog.Log("Lines count:" + lines.Count());

                int rowcounter = 0;
                string flowName = "";
                
                foreach (string line in lines)
                {
                    if (rowcounter > 0)
                    {
                        string[] columns = line.Split(',');
                        columncount = 1;
                        var flowsessiontrace = new Entity("autocoe_flowsessiontrace");
                        foreach (string column in columns)
                        {
                            if (columncount == 1)
                                flowsessiontrace.Attributes["autocoe_automationprojectid"] = column;
                            else if (columncount == 2)

                                if (!string.IsNullOrEmpty(column.ToString()))
                                {   
                                    
                                    if ( !DateTime.TryParseExact(column.ToString(), "MM/dd/yyyy hh:mm:ss tt",
                                                               CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                               out DTcompletedon))
                                    {
                                        DTcompletedon = DateTime.Parse(column.ToString());
                                    }

                                    flowsessiontrace.Attributes["autocoe_completedon"] = DTcompletedon;                                    
                                }
                                else
                                    flowsessiontrace.Attributes["autocoe_completedon"] = null;

                            else if (columncount == 3)
                                flowsessiontrace.Attributes["autocoe_connectiontype"] = column;
                            else if (columncount == 4)
                                flowsessiontrace.Attributes["autocoe_department"] = column;
                            else if (columncount == 5)
                                flowsessiontrace.Attributes["autocoe_environmentid"] = CrmSvc.EnvironmentId;
                            else if (columncount == 6)
                                flowsessiontrace.Attributes["autocoe_environmentname"] = CrmSvc.ConnectedOrgFriendlyName;
                            else if (columncount == 7)
                                flowsessiontrace.Attributes["autocoe_environmentregion"] = column;
                            else if (columncount == 8)
                                flowsessiontrace.Attributes["autocoe_environmentuniquename"] = CrmSvc.ConnectedOrgUniqueName;// unique name
                            else if (columncount == 9)
                                flowsessiontrace.Attributes["autocoe_exceptioncode"] = column;
                            else if (columncount == 10)
                                flowsessiontrace.Attributes["autocoe_exceptiondetails"] = column;
                            else if (columncount == 11)
                                flowsessiontrace.Attributes["autocoe_exceptionsource"] = column;
                            else if (columncount == 12)
                                flowsessiontrace.Attributes["autocoe_flowid"] = column;
                            else if (columncount == 13)
                            {
                                flowName = column;
                                flowsessiontrace.Attributes["autocoe_flowname"] = column;
                            }
                            else if (columncount == 14)
                                flowsessiontrace.Attributes["autocoe_flowrunid"] = column;
                            else if (columncount == 15)
                                flowsessiontrace.Attributes["autocoe_flowsessionid"] = column;
                            //if (columncount == 16) 
                            //    flowsessiontrace.Attributes["autocoe_flowsessiontraceid"] = column;
                            else if (columncount == 17)
                                flowsessiontrace.Attributes["autocoe_flowtriggeruri"] = column;
                            else if (columncount == 18)

                                if (column.ToString().ToUpper() == "FALSE")
                                    flowsessiontrace.Attributes["autocoe_flowtype"] = false;
                                else
                                    flowsessiontrace.Attributes["autocoe_flowtype"] = true;

                            else if (columncount == 19)
                                flowsessiontrace.Attributes["autocoe_hostname"] = column;
                            //else if (columncount == 20)
                            //    flowsessiontrace.Attributes["importsequencenumber"] = column;
                            else if (columncount == 21)
                                flowsessiontrace.Attributes["autocoe_maker"] = ProjectBusinessOwner;
                            else if (columncount == 22)
                                flowsessiontrace.Attributes["autocoe_overallstatus"] = column;
                            else if (columncount == 23)
                                flowsessiontrace.Attributes["autocoe_runmode"] = column;
                            else if (columncount == 24)
                                flowsessiontrace.Attributes["autocoe_solutionid"] = column;
                            else if (columncount == 25)
                                flowsessiontrace.Attributes["autocoe_solutionname"] = column;
                            //else if (columncount == 26)
                            //    flowsessiontrace.Attributes["autocoe_solutionowner"] = column;
                            //else if (columncount == 27)
                            //    flowsessiontrace.Attributes["autocoe_solutionowneremail"] = column;
                            else if (columncount == 28)
                                if (!string.IsNullOrEmpty(column.ToString()))
                                {                                    
                                    DTcompletedon = DateTime.Parse(column.ToString());                                    
                                    flowsessiontrace.Attributes["autocoe_startedon"] = DTcompletedon;
                                }
                                else
                                    flowsessiontrace.Attributes["autocoe_startedon"] = null;

                            else if (columncount == 34)
                                flowsessiontrace.Attributes["autocoe_workflowuniqueid"] = column;

                            columncount += 1;
                        }

                        EMRequests.Requests.Add(new UpsertRequest { Target = flowsessiontrace });
                        if (EMRequests.Requests.Count == const_NoOfRecordsForBatchProcessing)
                        {
                            try
                            {
                                CrmSvc.Execute(EMRequests);
                                EMRequests.Requests.Clear();
                                result = true;
                            }
                            catch (Exception ex )
                            {
                                PackageLog.Log("unable to fllw session trace record for " + flowName + "Error=" + ex.Message);
                                result = false;

                            }                           
                            
                      }
                    }
                    rowcounter += 1;
                }

                if (EMRequests.Requests.Count > 0)
                {
                    CrmSvc.Execute(EMRequests);
                }

                PackageLog.Log("Completed - inserting records for flow sessoin trace table on " + DateTime.Now.ToString());
                result= true;

            }
            else
            {
                result= false;
            }

            return result;

        }

    }
}

