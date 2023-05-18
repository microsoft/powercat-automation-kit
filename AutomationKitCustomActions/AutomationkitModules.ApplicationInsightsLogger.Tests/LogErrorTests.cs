using Microsoft.PowerPlatform.PowerAutomate.Desktop.Actions.SDK.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutomationkitModules.ApplicationInsightsLogger.Tests
{
    [TestClass]
    public class LogErrorTests
    {
        [TestMethod]
        public void Action_IsValid()
        {
            bool isValid = ActionValidator.IsValid(typeof(LogError), out var errors);

            Assert.IsTrue(isValid, $"Action is invalid. Validation Errors: {Environment.NewLine}{string.Join(Environment.NewLine, errors)}");
        }

        [TestMethod]
        public void Action_Execute_Success()
        {
            try
            {
                LogError action = new LogError() { ConnectionString = "InstrumentationKey=cf31470d-2fc5-4ac1-97c1-a5e922138475;IngestionEndpoint=https://eastus-8.in.applicationinsights.azure.com/;LiveEndpoint=https://eastus.livediagnostics.monitor.azure.com/", ErrorMessage="Test Error using Automation Kit Custom Actions"};
                action.Execute(null);
                var actionOutput = action.OutPutMessage;
            }
            catch (Exception e)
            {
                Assert.Fail("Expected no exception, but got: " + e.Message);
            }
        }
    }
}
