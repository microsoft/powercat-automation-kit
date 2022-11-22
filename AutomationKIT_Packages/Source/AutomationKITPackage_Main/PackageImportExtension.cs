using System;
using System.ComponentModel.Composition;
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
        private bool NeedToEnablePCF = false;
        private bool ImportSampleData = false;
        
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
                        else if (strKey.Contains("enablepcf"))
                        {
                            bool.TryParse(strValue, out NeedToEnablePCF);
                            PackageLog.Log("NeedToEnablePCF=" + NeedToEnablePCF.ToString());
                        }                        
                    }
                                                            
                }                

            }
            catch (Exception ex)
            {
                PackageLog.Log("Error occured in while reading runtime settings. Please find the original exception details::" + ex.Message.ToString());
            }
            
            if (NeedToEnablePCF)
            { 
            try
            {
                PackageLog.Log("Started enabling of PCF on " + DateTime.Now.ToString());
                // Since this solution requires that PCF in canvas is enabled in the envrionment, we need to set that setting.
                var query = new QueryExpression("organization");
                query.ColumnSet.AddColumns("iscustomcontrolsincanvasappsenabled");
                var result = CrmSvc.RetrieveMultiple(query);
                var environmentSettings = result.Entities[0];
                // Enable PCF for canvas
                environmentSettings["iscustomcontrolsincanvasappsenabled"] = true;
                CrmSvc.Update(environmentSettings);
                PackageLog.Log("Completed enabling of PCF on " + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                PackageLog.Log("Unable to update pcf components on this enivronment. Please find the original exception details::" + ex.Message.ToString());
            }
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

            PackageLog.Log("PreSolutionImport is started on " + DateTime.Now.ToString() + " with parameters::" + "solutionName=" +solutionName + ",solutionOverwriteUnmanagedCustomizations=" + solutionOverwriteUnmanagedCustomizations + ",solutionPublishWorkflowsAndActivatePlugins=" + solutionPublishWorkflowsAndActivatePlugins);
            
            base.PreSolutionImport(solutionName, solutionOverwriteUnmanagedCustomizations, solutionPublishWorkflowsAndActivatePlugins, out overwriteUnmanagedCustomizations, out publishWorkflowsAndActivatePlugins);
            
            PackageLog.Log("presolutionImport is completed on " + DateTime.Now.ToString() + ", DataImportBypass =" +DataImportBypass);
                        
        }
        public override UserRequestedImportAction OverrideSolutionImportDecision(string solutionUniqueName, Version organizationVersion, Version packageSolutionVersion, Version inboundSolutionVersion, Version deployedSolutionVersion, ImportAction systemSelectedImportAction)
        {
            PackageLog.Log("OverrideSolutionImportDecision is started on " + DateTime.Now.ToString() + " with parameters:: solutionUniqueName=" + solutionUniqueName + ",organizationVersion=" + organizationVersion + ",packageSolutionVersion=" + packageSolutionVersion + ",inboundSolutionVersion=" + inboundSolutionVersion + ",deployedSolutionVersion=" + deployedSolutionVersion + ",systemSelectedImportAction=" + systemSelectedImportAction);

            if(NeedToImportMainSolution && solutionUniqueName.ToString().ToLower().Contains("main"))
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
            
            return true;
        }
        
    }
}
