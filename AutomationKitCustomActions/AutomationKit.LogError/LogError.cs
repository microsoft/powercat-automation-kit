using Microsoft.PowerPlatform.PowerAutomate.Desktop.Actions.SDK;
using Microsoft.PowerPlatform.PowerAutomate.Desktop.Actions.SDK.Attributes;
using System;

namespace AutomationKit.LogError
{
    [Action(Id = "LogError", Order = 1, FriendlyName = "Action 1", Description = "Description of Action 1")]
    [Throws("ActionError")] // TODO: change error name (or delete if not needed)
    public class LogError : ActionBase
    {
        #region Properties

        [InputArgument(FriendlyName = "Input Argument", Description = "Description of InputArgument")]
        public string InputArgument1 { get; set; }

        [OutputArgument(FriendlyName = "Output Argument", Description = "Description of OutputArgument")]
        public string OutputArgument1 { get; set; }

        #endregion

        #region Methods Overrides

        public override void Execute(ActionContext context)
        {
            try
            {
                OutputArgument1 = "this is test";
            }
            catch (Exception e)
            {
                if (e is ActionException) throw;

                throw new ActionException("ActionError", e.Message, e.InnerException);
            }

            // TODO: set values to Output Arguments here
        }

        #endregion
    }
}
