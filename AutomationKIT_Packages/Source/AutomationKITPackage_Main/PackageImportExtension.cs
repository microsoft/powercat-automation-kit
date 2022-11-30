using System;
using System.ComponentModel.Composition;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;
using Microsoft.Xrm.Sdk;
using System.Collections.Specialized;

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

        /// <summary>
        /// Called to Initialize any functions in the Custom Extension.
        /// </summary>
        /// <see cref="ImportExtension.InitializeCustomExtension"/>
        public override void InitializeCustomExtension()
        {
            string strKey;
            string strValue;
                       
            PackageLog.Log("InitializeCustomExtension is started on " + DateTime.Now.ToString());
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
                            DataImportBypass = (ImportSampleData ? false : true);
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
            PackageLog.Log("AfterPrimaryImport is completed on " + DateTime.Now.ToString());
            //UpdateProjectAppDetails();
            AssignUsersToRoles();
            ActivateDeActivateCloudFlows();
            UpdateBusinessOwnertoExistingProjects(ProjectBusinessOwner);
            
            return true;
        }
        private void ActivateDeActivateCloudFlows()
        {
            StringCollection flows = new StringCollection();
            flows.Add("Automation Project - Approvals");
            flows.Add("Calculate ROI Saving Potential for Automation Project");
            flows.Add("Sync Environments");
            
            foreach (string flow in flows)
            {
                switch (flow)
                {
                    case "Automation Project - Approvals":
                        ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateApprovalFlow);
                        break;
                    case "Calculate ROI Saving Potential for Automation Project":
                        ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateROIFlow);
                        break;
                    case "Sync Environments":
                        ActivateDeActivateCloudFlow(flow.ToString(), NeedToActivateSyncFlow);
                        break;
                    default:
                        // other flows should be de-activated
                        ActivateDeActivateCloudFlow(flow.ToString(), false);
                        break;
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
            string SecurityRole = string.Empty;

            if (!string.IsNullOrEmpty(ProjectAdminUsers))
            {
                SecurityRole = "Automation Project Admin";
                AssignUsersToRole(ProjectAdminUsers, SecurityRole);
            }

            if (!string.IsNullOrEmpty(ProjectContributors))
            {
                SecurityRole = "Automation Project Contributor";
                AssignUsersToRole(ProjectContributors, SecurityRole);
            }

            if (!string.IsNullOrEmpty(ProjectViewers))
            {
                SecurityRole = "Automation Project Viewer";
                AssignUsersToRole(ProjectViewers, SecurityRole);
            }
        }
        private void AssignUsersToRole(string userEmailslist, string securityRole)
        {
            PackageLog.Log("Assigning users to security role '" + securityRole + "'");

            Guid userid = Guid.Empty;
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

                    userid = (Guid)results["systemuserid"];

                    //assigning user to role
                    if (roleid != Guid.Empty && userid != Guid.Empty)
                    {
                        try
                        {
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
        private void UpdateBusinessOwnertoExistingProjects(string userEmailid)
        {
            PackageLog.Log("Updating business owner to existing projects");

            if (!string.IsNullOrEmpty(userEmailid))
            {
                // getting projects to update business owner emailid for old data
                var queryPrjects = new QueryExpression("autocoe_automationproject");
                queryPrjects.ColumnSet.AddColumns("autocoe_businessowneremail");
                queryPrjects.Criteria.AddCondition("autocoe_businessowneremail", ConditionOperator.Equal, "administrator@contoso.onmicrosoft.com");
                try
                {
                    var resultProjects = CrmSvc.RetrieveMultiple(queryPrjects);
                    var results = resultProjects.Entities[0];

                    foreach (Entity proj in resultProjects.Entities)
                    {
                        proj["autocoe_businessowneremail"] = userEmailid;

                        CrmSvc.Update(proj);
                    }

                }
                catch (Exception ex)
                {
                    PackageLog.Log("Unable to update business owner for existing projects. Erorr: " + ex.Message.ToString());
                }

                PackageLog.Log("Completed of updating business owner to existing projects");
            }

        }

    }
}

