using System;
using System.ComponentModel.Composition;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;

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
        public override string GetNameOfImport(bool plural) => "AutomationKIT For Satellite environment";

        /// <summary>
        /// Long name of the Import Package.
        /// </summary>
        public override string GetLongNameOfImport => "Automation KIT for Satellite environment";

        /// <summary>
        /// Description of the package, used in the package selection UI
        /// </summary>
        public override string GetImportPackageDescriptionText => "Automation kit provides a set of templates and tools beyond the core Admin controls in the product for organizations to customize how they roll out and manage Power Platform Automation solutions for satellite environment.";

        private bool NeedToImportSatelliteSolution = false;        
        private bool ImportSampleData = false;
        private bool NeedToActivateAllFlows = false;

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
                        else if (strKey.Contains("installsatellitesolution"))
                        {
                            bool.TryParse(strValue, out NeedToImportSatelliteSolution);
                            PackageLog.Log("NeedToImportSatelliteSolution=" + NeedToImportSatelliteSolution.ToString());
                        }                        
                        else if (strKey.Contains("activateallflows"))
                        {
                            bool.TryParse(strValue, out NeedToActivateAllFlows);
                            PackageLog.Log("NeedToActivateAllFlows=" + NeedToActivateAllFlows.ToString());
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
        /// Called before the Satellite Import process begins, after solutions and data.
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

            PackageLog.Log("PreSolutionImport is started on " + DateTime.Now.ToString() + " with parameters::" + "solutionName=" +solutionName + ",solutionOverwriteUnmanagedCustomizations=" + solutionOverwriteUnmanagedCustomizations + ",solutionPublishWorkflowsAndActivatePlugins=" + solutionPublishWorkflowsAndActivatePlugins);
            
            base.PreSolutionImport(solutionName, solutionOverwriteUnmanagedCustomizations, solutionPublishWorkflowsAndActivatePlugins, out overwriteUnmanagedCustomizations, out publishWorkflowsAndActivatePlugins);
            
            PackageLog.Log("presolutionImport is completed on " + DateTime.Now.ToString() + ", DataImportBypass =" +DataImportBypass);
                        
        }
        public override UserRequestedImportAction OverrideSolutionImportDecision(string solutionUniqueName, Version organizationVersion, Version packageSolutionVersion, Version inboundSolutionVersion, Version deployedSolutionVersion, ImportAction systemSelectedImportAction)
        {
            PackageLog.Log("OverrideSolutionImportDecision is started on " + DateTime.Now.ToString() + " with parameters:: solutionUniqueName=" + solutionUniqueName + ",organizationVersion=" + organizationVersion + ",packageSolutionVersion=" + packageSolutionVersion + ",inboundSolutionVersion=" + inboundSolutionVersion + ",deployedSolutionVersion=" + deployedSolutionVersion + ",systemSelectedImportAction=" + systemSelectedImportAction);

            if(NeedToImportSatelliteSolution && solutionUniqueName.ToString().ToLower().Contains("satellite"))
                return UserRequestedImportAction.Default; //import satellite solution            
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
            ActivateDeActivateAllCloudFlows();            
            return true;
        }
        private void ActivateDeActivateAllCloudFlows()
        {
            PackageLog.Log("Started activation/de-activation for all flows" );
            string solutionName = "AutomationCoESatellite";

            var querysolution = new QueryExpression("solution");

            querysolution.ColumnSet.AddColumns("solutionid");            
            querysolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solutionName);

            var resultsolution = CrmSvc.RetrieveMultiple(querysolution);
            var results = resultsolution.Entities[0];
            string solutionid = results["solutionid"].ToString();

            var queryflow = new QueryExpression("workflow");
            queryflow.ColumnSet.AddColumns("name");
            queryflow.ColumnSet.AddColumns("workflowid");
            queryflow.Criteria.AddCondition("solutionid", ConditionOperator.Equal, solutionid);
            try
            {
                var resultflows = CrmSvc.RetrieveMultiple(queryflow);

                string flowid = "";
                string flowName="";

                foreach (Entity flow in resultflows.Entities)
                {
                    flowid = flow["workflowid"].ToString();
                    flowName = flow["name"].ToString();

                    ActivateDeActivateCloudFlow(flowid, flowName, NeedToActivateAllFlows);
                }
                
            }
            catch (Exception err)
            {
                PackageLog.Log("Error occured while activating / de-activating flows. Error is " + err.Message.ToString());
                return;
            }

            PackageLog.Log("Completed activation/de-activation for all flows  successfully.");

        }             
        private void ActivateDeActivateCloudFlow(string flowId,string flow_Name, bool enableFlow)
        {
            PackageLog.Log("Started activation/de-activation for flow '" + flow_Name + "'");

            var queryflow = new QueryExpression("workflow");
            queryflow.ColumnSet.AddColumns("statecode");
            queryflow.ColumnSet.AddColumns("statuscode");
            queryflow.ColumnSet.AddColumns("workflowid");
            queryflow.Criteria.AddCondition("workflowid", ConditionOperator.Equal, flowId);
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
                PackageLog.Log("Error occured while activating / de-activating the flow '" + flow_Name + "'. Error is " + err.Message.ToString());
                return;
            }

            PackageLog.Log("Completed activation/de-activation for flow '" + flow_Name + "' successfully.");

        }

            }
}
