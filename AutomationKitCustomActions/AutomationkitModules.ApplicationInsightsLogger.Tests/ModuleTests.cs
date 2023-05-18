using Microsoft.PowerPlatform.PowerAutomate.Desktop.Actions.SDK.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutomationkitModules.ApplicationInsightsLogger.Tests
{
    [TestClass]
    public class ModuleTests
    {
        [TestMethod]
        public void Module_IsValid()
        {
            string moduleDllPath = "C:\\Users\\pmohapatra\\source\\repos\\microsoft\\powercat-automation-kit\\AutomationKitCustomActions\\AutomationkitModules.ApplicationInsightsLogger\\bin\\Debug\\net472\\AutomationkitModules.ApplicationInsightsLogger.dll"; //TODO: Set correct dll path
            bool isValid = ModuleValidator.IsValid(moduleDllPath, out var errors);

            Assert.IsTrue(isValid, $"Module is invalid. Validation Errors: {Environment.NewLine}{string.Join(Environment.NewLine, errors)}");
        }
    }
}
