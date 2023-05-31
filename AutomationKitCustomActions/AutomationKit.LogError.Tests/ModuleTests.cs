using Microsoft.PowerPlatform.PowerAutomate.Desktop.Actions.SDK.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutomationKit.LogError.Tests
{
    [TestClass]
    public class ModuleTests
    {
        [TestMethod]
        public void Module_IsValid()
        {
            string moduleDllPath = "path_to_generated_module_dll"; //TODO: Set correct dll path
            bool isValid = ModuleValidator.IsValid(moduleDllPath, out var errors);

            Assert.IsTrue(isValid, $"Module is invalid. Validation Errors: {Environment.NewLine}{string.Join(Environment.NewLine, errors)}");
        }
    }
}
