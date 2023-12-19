﻿using System;
using System.ComponentModel.Composition;
using System.IO;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;

namespace PowerCAT.PackageDeployer.Package
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
        public override string GetNameOfImport(bool plural) => "PowerCATPackage";

        /// <summary>
        /// Long name of the Import Package.
        /// </summary>
        public override string GetLongNameOfImport => "PowerCATPackage";

        /// <summary>
        /// Description of the package, used in the package selection UI
        /// </summary>
        public override string GetImportPackageDescriptionText => "PowerCATPackage";

        #endregion

        public string FilePath { get; set; }
        public string ProjectName { get; set; }

        /// <summary>
        /// Called to Initialize any functions in the Custom Extension.
        /// </summary>
        /// <see cref="ImportExtension.InitializeCustomExtension"/>
        public override void InitializeCustomExtension()
        {
            // Validate the state of the runtime settings object.  
            if (RuntimeSettings != null)
            {
                PackageLog.Log(string.Format("Runtime Settings populated.  Count = {0}", RuntimeSettings.Count));
                foreach (var setting in RuntimeSettings)
                {
                    PackageLog.Log(string.Format("Key={0} | Value={1}", setting.Key, setting.Value.ToString()));
                }

                // Check to file path provided.  
                if (RuntimeSettings.ContainsKey("filepath"))
                {
                    FilePath = RuntimeSettings["filepath"].ToString();
                }

                if (RuntimeSettings.ContainsKey("projectname"))
                {
                    ProjectName = RuntimeSettings["projectname"].ToString();
                }
            }
            else
            {
                PackageLog.Log("Runtime Settings not populated");
            }

            if (string.IsNullOrEmpty(FilePath) || string.IsNullOrEmpty(ProjectName))
            {
                PackageLog.Log("Missing required parameters.  Skipping PreDeploymentSettings and PostDeploymentSettings import.");
                return;
            }

            Console.WriteLine($"Project Name : {ProjectName}");
            Console.WriteLine($"File Path : {FilePath}");

            var preDeploymentSettings = JsonUtility.ReadPreDeploymentSettings(FilePath, ProjectName);

            if (preDeploymentSettings != null)
            {
                // Process the PreDeploymentSettings dictionary
                Console.WriteLine($"PreDeploymentSettings for {ProjectName}:");

                var organizationSettingsUpdater = new OrganizationSettingsUpdater(CrmSvc);

                foreach (var setting in preDeploymentSettings)
                {
                    Console.WriteLine($"Updating Key : {setting.Key} Value: {setting.Value}");
                    // Call UpdateOrganizationSettings with setting.Key and setting.Value
                    organizationSettingsUpdater.UpdateOrganizationSettings(setting.Key, setting.Value);
                }
            }
            else
            {
                Console.WriteLine($"Project with name '{ProjectName}' or PreDeploymentSettings not found.");
            }
        }

        /// <summary>
        /// Called before the Main Import process begins, after solutions and data.
        /// </summary>
        /// <see cref="ImportExtension.BeforeImportStage"/>
        /// <returns></returns>
        public override bool BeforeImportStage()
        {
            return true;
        }

        /// <summary>
        /// Raised before the named solution is imported to allow for any configuration settings to be made to the import process
        /// </summary>
        /// <see cref="ImportExtension.PreSolutionImport"/>
        /// <param name="solutionName">name of the solution about to be imported</param>
        /// <param name="solutionOverwriteUnmanagedCustomizations">Value of this field from the solution configuration entry</param>
        /// <param name="solutionPublishWorkflowsAndActivatePlugins">Value of this field from the solution configuration entry</param>
        /// <param name="overwriteUnmanagedCustomizations">If set to true, imports the Solution with Override Customizations enabled</param>
        /// <param name="publishWorkflowsAndActivatePlugins">If set to true, attempts to auto publish workflows and activities as part of solution deployment</param>
        public override void PreSolutionImport(string solutionName, bool solutionOverwriteUnmanagedCustomizations, bool solutionPublishWorkflowsAndActivatePlugins, out bool overwriteUnmanagedCustomizations, out bool publishWorkflowsAndActivatePlugins)
        {
            Console.WriteLine($"PreSolutionImport : {solutionName}");
            Console.WriteLine($"Project Name : {ProjectName}");
            Console.WriteLine($"File Path : {FilePath}");
            base.PreSolutionImport(solutionName, solutionOverwriteUnmanagedCustomizations, solutionPublishWorkflowsAndActivatePlugins, out overwriteUnmanagedCustomizations, out publishWorkflowsAndActivatePlugins);
        }

        /// <summary>
        /// Called during a solution upgrade when both solutions, old and new, are present in the system.
        /// This function can be used to provide a means to do data transformation or upgrade while a solution update is occurring.
        /// </summary>
        /// <see cref="ImportExtension.RunSolutionUpgradeMigrationStep"/>
        /// <param name="solutionName">Name of the solution</param>
        /// <param name="oldVersion">version number of the old solution</param>
        /// <param name="newVersion">Version number of the new solution</param>
        /// <param name="oldSolutionId">Solution ID of the old solution</param>
        /// <param name="newSolutionId">Solution ID of the new solution</param>
        public override void RunSolutionUpgradeMigrationStep(string solutionName, string oldVersion, string newVersion, Guid oldSolutionId, Guid newSolutionId)
        {
            base.RunSolutionUpgradeMigrationStep(solutionName, oldVersion, newVersion, oldSolutionId, newSolutionId);
        }

        /// <summary>
        /// Called After all Import steps are complete, allowing for final customizations or tweaking of the instance.
        /// </summary>
        /// <see cref="ImportExtension.AfterPrimaryImport"/>
        /// <returns></returns>
        public override bool AfterPrimaryImport()
        {
            Console.WriteLine("AfterPrimaryImport");
            Console.WriteLine($"Project Name : {ProjectName}");
            Console.WriteLine($"File Path : {FilePath}");
            return true;
        }
    }
}
