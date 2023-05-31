using Microsoft.PowerPlatform.PowerAutomate.Desktop.Actions.SDK.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutomationKit.LogError.Tests
{
    [TestClass]
    public class Action1Tests
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
                LogError action = new LogError() { InputArgument1 = "Test Input" };
                action.Execute(null);
                var actionOutput = action.OutputArgument1;
            }
            catch (Exception e)
            {
                Assert.Fail("Expected no exception, but got: " + e.Message);
            }
        }
    }
}
