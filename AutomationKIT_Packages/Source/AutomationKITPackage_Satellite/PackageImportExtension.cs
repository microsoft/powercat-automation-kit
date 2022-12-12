using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;
using System.Threading.Tasks;

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

        private bool NeedToImportSatelliteSolution;        
        private bool ImportSampleData;
        private bool NeedToActivateAllFlows;
        private string CurrentSolutionName;

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
                            DataImportBypass = (!ImportSampleData);
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

            CurrentSolutionName = solutionName;
            
            PackageLog.Log("PreSolutionImport is started on " + DateTime.Now.ToString() + " with parameters::" + "solutionName=" +solutionName + ",solutionOverwriteUnmanagedCustomizations=" + solutionOverwriteUnmanagedCustomizations + ",solutionPublishWorkflowsAndActivatePlugins=" + solutionPublishWorkflowsAndActivatePlugins);
            
            base.PreSolutionImport(solutionName, solutionOverwriteUnmanagedCustomizations, solutionPublishWorkflowsAndActivatePlugins, out overwriteUnmanagedCustomizations, out publishWorkflowsAndActivatePlugins);
            
            PackageLog.Log("presolutionImport is completed on " + DateTime.Now.ToString() + ", DataImportBypass =" +DataImportBypass);
                        
        }
        public override UserRequestedImportAction OverrideSolutionImportDecision(string solutionUniqueName, Version organizationVersion, Version packageSolutionVersion, Version inboundSolutionVersion, Version deployedSolutionVersion, ImportAction systemSelectedImportAction)
        {
            PackageLog.Log("OverrideSolutionImportDecision is started on " + DateTime.Now.ToString() + " with parameters:: solutionUniqueName=" + solutionUniqueName + ",organizationVersion=" + organizationVersion + ",packageSolutionVersion=" + packageSolutionVersion + ",inboundSolutionVersion=" + inboundSolutionVersion + ",deployedSolutionVersion=" + deployedSolutionVersion + ",systemSelectedImportAction=" + systemSelectedImportAction);

            CurrentSolutionName = solutionUniqueName;

            if (NeedToImportSatelliteSolution && solutionUniqueName.ToString().ToLower().Contains("satellite"))
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
            InsertRecordstoDesktopFlowActionsTable();
            ActivateDeActivateAllCloudFlows();
            return true;
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

                int columncount;
                string[] lines = System.IO.File.ReadAllLines(csvpath);
                bool dlpImpact;
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
                            Guid RecordID;
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
        private void ActivateDeActivateAllCloudFlows()
        {
            PackageLog.Log("Started activation/de-activation for all flows for solution " + CurrentSolutionName);
            var querysolution = new QueryExpression("solution");

            querysolution.ColumnSet.AddColumns("solutionid");            
            querysolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, CurrentSolutionName);

            var resultsolution = CrmSvc.RetrieveMultiple(querysolution);
            var results = resultsolution.Entities[0];
            string solutionid = results["solutionid"].ToString();

            var queryflow = new QueryExpression("workflow");
            queryflow.ColumnSet.AddColumns("name");
            queryflow.ColumnSet.AddColumns("workflowid");
            queryflow.ColumnSet.AddColumns("statecode");
            queryflow.ColumnSet.AddColumns("statuscode");
            queryflow.Criteria.AddCondition("solutionid", ConditionOperator.Equal, solutionid);
            try
            {
                var resultflows = CrmSvc.RetrieveMultiple(queryflow);

                string flowid;
                string flowName;

                if (resultflows.Entities.Count > 0) 
                {
                    foreach (Entity flow in resultflows.Entities)
                    {
                        flowid = flow["workflowid"].ToString();
                        flowName = flow["name"].ToString();

                        if (NeedToActivateAllFlows)
                        {
                            flow["statecode"] = new OptionSetValue(1);
                            flow["statuscode"] = new OptionSetValue(2);
                        }
                        else
                        {
                            flow["statecode"] = new OptionSetValue(0);
                            flow["statuscode"] = new OptionSetValue(1);
                        }
                        try
                        {
                            CrmSvc.Update(flow);
                        }
                        catch (Exception err)
                        {
                            PackageLog.Log("Error occured while activating / de-activating for flow "+ flowName +". Error is " + err.Message.ToString());
                        }
                        
                    }
                }

                if (NeedToActivateAllFlows)
                {
                    queryflow = new QueryExpression("workflow");
                    queryflow.ColumnSet.AddColumns("name");
                    queryflow.ColumnSet.AddColumns("workflowid");
                    queryflow.ColumnSet.AddColumns("statecode");
                    queryflow.ColumnSet.AddColumns("statuscode");
                    queryflow.Criteria.AddCondition("solutionid", ConditionOperator.Equal, solutionid);
                    queryflow.Criteria.AddCondition("statecode", ConditionOperator.Equal, 0);
                    
                    resultflows = CrmSvc.RetrieveMultiple(queryflow);
                   
                    if (resultflows.Entities.Count > 0)
                    {
                        foreach (Entity flow in resultflows.Entities)
                        {
                            flowid = flow["workflowid"].ToString();
                            flowName = flow["name"].ToString();

                            int i = 0;
                            while (i < 5)
                            {
                                flow["statecode"] = new OptionSetValue(1);
                                flow["statuscode"] = new OptionSetValue(2);

                                try
                                {
                                    CrmSvc.Update(flow);
                                    break;
                                }
                                catch (Exception err)
                                {
                                    PackageLog.Log("Error occured while activating flow '" + flowName + "' for counter="+ i +". Error is " + err.Message.ToString());
                                    i++;
                                    System.Threading.Thread.Sleep(3000);
                                }
                            }

                        }

                    }

                }
            }
            catch (Exception err)
            {
                PackageLog.Log("Error occured while fetching flow details for solution " + CurrentSolutionName +". Error is " + err.Message.ToString());
                return;
            }

            PackageLog.Log("Completed activation/de-activation for all flows  successfully.");

        }
     
    }
}
