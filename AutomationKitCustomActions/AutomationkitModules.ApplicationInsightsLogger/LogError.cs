using Microsoft.PowerPlatform.PowerAutomate.Desktop.Actions.SDK;
using Microsoft.PowerPlatform.PowerAutomate.Desktop.Actions.SDK.Attributes;
using System;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.DataContracts;

namespace AutomationkitModules.ApplicationInsightsLogger
{
    [Action(Id = "LogError", Order = 1)]
    [Throws("LoggingActionError")] // TODO: change error name (or delete if not needed)
    public class LogError : ActionBase
    {
        #region Properties

        // NOTE: You can find sample description and friendly name entries in Resources

        [InputArgument]
        public string ConnectionString { get; set; }
        [InputArgument]
        public string ErrorMessage { get; set; }

        [OutputArgument]
        public string OutPutMessage { get; set; }

        #endregion

        #region Methods Overrides

        public override void Execute(ActionContext context)
        {
            TelemetryClient telemetryClient = new TelemetryClient(TelemetryConfiguration.CreateDefault()); ;

            try
            {
                // Retrieve your Application Insights connection string from configuration
             
                TelemetryConfiguration telemetryConfig = TelemetryConfiguration.CreateDefault();
                telemetryConfig.ConnectionString = ConnectionString;
                telemetryClient = new TelemetryClient(telemetryConfig);
                // Create an exception telemetry object
                ExceptionTelemetry exceptionTelemetry = new ExceptionTelemetry();

                // Set the exception details
                exceptionTelemetry.Exception = new Exception(ErrorMessage);
                exceptionTelemetry.SeverityLevel = SeverityLevel.Error;
                // Track the exception telemetry
                telemetryClient.TrackException(exceptionTelemetry);



            }
            catch (Exception e)
            {
                if (e is ActionException) throw;

                throw new ActionException("LoggingActionError", e.Message, e.InnerException);
            }
            finally
            {
                // Flush Application Insights data
                telemetryClient.Flush();
            }
            // TODO: set values to Output Arguments here
        }

        #endregion
    }
}
