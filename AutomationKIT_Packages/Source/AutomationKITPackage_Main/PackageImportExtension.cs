using System;
using System.ComponentModel.Composition;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;
using Microsoft.Xrm.Sdk;
using System.Collections.Specialized;
using System.Reflection;
using System.IO;

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
            AssignUsersToRoles();
            ActivateDeActivateCloudFlows();
            UpdateBusinessOwnertoExistingProjects(ProjectBusinessOwner);
            UpdateConsoleConfigurations();
            InsertRecordstoDesktopFlowActionsTable();
            PackageLog.Log("AfterPrimaryImport is completed on " + DateTime.Now.ToString());
            return true;
        }
        private void ActivateDeActivateCloudFlows()
        {
            StringCollection flows = new StringCollection
            {
                const_Approval_Flow_Name,
                const_Calc_ROI_Flow_Name,
                const_Sync_Env_Flow_Name
            };

            foreach (string flow in flows)
            {
                if (flow == const_Approval_Flow_Name)
                {
                    ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateApprovalFlow);
                }
                else if (flow == const_Calc_ROI_Flow_Name)
                {
                    ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateROIFlow);
                }
                else if (flow == const_Sync_Env_Flow_Name)
                {
                    ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateSyncFlow);
                }
                else
                {
                    // other flows should be de-activated
                    ActivateDeActivateCloudFlow(flow.ToString(), false);
                }                
            }
        }
        private void ActivateDeActivateCloudFlow(string flowName, bool enableFlow)
        {
            PackageLog.Log("Started activation/de-activation for flow '" + flowName + "'");

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
            }
            catch (Exception err)
            {
                PackageLog.Log("Error occured while activating / de-activating the flow '" + flowName + "'. Error is " + err.Message.ToString());
                return;
            }

            PackageLog.Log("Completed activation/de-activation for flow '" + flowName + "' successfully.");

        }        
        private void AssignUsersToRoles()
        {
            if (!string.IsNullOrEmpty(ProjectAdminUsers))
            {
                
                AssignUsersToRole(ProjectAdminUsers, const_Security_Name_Project_Admin);
            }

            if (!string.IsNullOrEmpty(ProjectContributors))
            {
                
                AssignUsersToRole(ProjectContributors, const_Security_Name_Project_Contributor);
            }

            if (!string.IsNullOrEmpty(ProjectViewers))
            {
                AssignUsersToRole(ProjectViewers, const_Security_Name_Project_Viewer);
            }
        }
        private void AssignUsersToRole(string userEmailslist, string securityRole)
        {
            PackageLog.Log("Assigning users to security role '" + securityRole + "'");
            Guid roleid = Guid.Empty;

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
                        }
                        catch (Exception ex)
                        {
                            PackageLog.Log("Unable to assign user '" + usersList[i].ToString() + "' to security role '" + securityRole + "'. Error:" + ex.Message.ToString());
                        }
                    }

                }
            }

            PackageLog.Log("Completed of assigning roles");
        }
        private void UpdateBusinessOwnertoExistingProjects(string businessOwnerEmailId)
        {
            PackageLog.Log("Updating business owner to existing projects");

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
                        }
                    }

                }
                catch (Exception ex)
                {
                    PackageLog.Log("Unable to update business owner for existing projects. Erorr: " + ex.Message.ToString());
                }

                PackageLog.Log("Completed of updating business owner to existing projects");
            }

        }
        private void UpdateConsoleConfigurations()
        {
            PackageLog.Log("starting of Update console configurations ");
            
            
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
                    }
                }
                catch (Exception ex)
                {
                    PackageLog.Log("Unable to fetch canvas app details to update. Erorr: " + ex.Message.ToString());
                }

                PackageLog.Log("Completed for Updating console configurations ");
            }

        }
        private void InsertRecordstoDesktopFlowActionsTable()
        {
            // check the record count for flow action table
            var queryflowAction = new QueryExpression("autocoe_desktopflowaction");
            var resultflowaction = CrmSvc.RetrieveMultiple(queryflowAction);
            PackageLog.Log("Existing records count in desktop flow actions=" + resultflowaction.Entities.Count);

            string csvpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\PkgAssets\\autocoe_desktopflowactions.csv";

            if (resultflowaction.Entities.Count == 0)
            {
                PackageLog.Log("Start- Updating of desktop flow action records ");

                int columncount ;
                string[] lines = System.IO.File.ReadAllLines(csvpath);
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
                        try
                        {
                            Guid RecordID = CrmSvc.Create(flowAction);
                        }
                        catch (Exception ex)
                        {
                            PackageLog.Log("unable to cretae desktopflow action record for " + actionName + "Error=" + ex.Message);
                        }
                    }
                    rowcounter += 1;
                }

                PackageLog.Log("Completed - Updating of desktop flow action records ");

            }

        }

    }
}

