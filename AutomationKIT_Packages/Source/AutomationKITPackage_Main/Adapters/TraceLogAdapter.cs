using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace AutomationKIT_Main.Adapters
{
    [ExcludeFromCodeCoverage]
    public class TraceLoggerAdapter : ILogger
    {
        private static readonly Dictionary<LogLevel, TraceEventType> LogLevelMap = new Dictionary<LogLevel, TraceEventType>
        {
            { LogLevel.Trace, TraceEventType.Verbose },
            { LogLevel.Debug, TraceEventType.Verbose },
            { LogLevel.Information,  TraceEventType.Information },
            { LogLevel.Warning, TraceEventType.Warning },
            { LogLevel.Error, TraceEventType.Error },
            { LogLevel.Critical, TraceEventType.Critical },
        };

        private readonly TraceLogger traceLogger;
        /// <summary>
        /// Initializes a new instance of the <see cref="TraceLoggerAdapter"/> class.
        /// </summary>
        /// <param name="traceLogger">The <see cref="TraceLogger"/>.</param>
        public TraceLoggerAdapter(TraceLogger traceLogger)
        {
            if (traceLogger is null)
            {
                throw new ArgumentNullException(nameof(traceLogger));
            }

            (this.traceLogger, this.Warnings, this.Errors) = (traceLogger, new List<string>(), new List<string>());
        }

        /// <summary>
        /// Gets warning messages logged.
        /// </summary>
        public IList<string> Warnings { get; }

        /// <summary>
        /// Gets error messages logged.
        /// </summary>
        public IList<string> Errors { get; }

        /// <inheritdoc/>
        public IDisposable BeginScope<TState>(TState state) => default;

        /// <inheritdoc/>
        public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

        /// <inheritdoc/>
        public virtual void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!this.IsEnabled(logLevel))
            {
                return;
            }

            var message = formatter(state, exception);
            if (logLevel == LogLevel.Warning)
            {
                this.Warnings.Add(message);
            }
            else if (logLevel == LogLevel.Error || logLevel == LogLevel.Critical)
            {
                this.Errors.Add(message);
            }

            this.traceLogger.Log(
                $"{message} {(exception != null ? exception.StackTrace : string.Empty)}",
                LogLevelMap[logLevel]);
        }
    }

}
