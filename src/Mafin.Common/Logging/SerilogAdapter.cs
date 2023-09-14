using Serilog;

namespace Mafin.Common.Logging
{
    /// <summary>
    /// Provides a Serilog implementation for the <see cref="ILog"/> interface.
    /// </summary>
    public sealed class SerilogAdapter : ILog
    {
        private readonly Serilog.ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerilogAdapter"/> class.
        /// Initializes a new instance of the Serilog logger.
        /// </summary>
        public SerilogAdapter()
        {
            _logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();
        }

        /// <summary>
        /// Logs a debug message using the Serilog logger.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Debug(string message)
        {
            _logger.Debug(message);
        }

        /// <summary>
        /// Logs a debug message with the provided arguments using the Serilog logger.
        /// </summary>
        /// <param name="message">The message format passed to Serilog.</param>
        /// <param name="args">An object array that contains zero or more objects as arguments.</param>
        void ILog.Debug(string message, object?[] args)
        {
            _logger.Debug($"{message} {args}");
        }

        /// <summary>
        /// Logs an error message using the current logger.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Error(string message)
        {
            _logger.Error(message);
        }

        /// <summary>
        /// Logs a formatted error message using the current logger.
        /// </summary>
        /// <param name="message">The message format passed to the logger.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Error(string message, object?[] args)
        {
            _logger.Error($"{message} {args}");
        }

        /// <summary>
        /// Logs an informational message using the current logger.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Info(string message)
        {
            _logger.Information(message);
        }

        /// <summary>
        /// Logs a formatted informational message using the current logger.
        /// </summary>
        /// <param name="message">The formatted message to be logged.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Info(string message, object?[] args)
        {
            _logger.Information($"{message} {args}");
        }

        /// <summary>
        /// Logs a trace/verbose message using the current logger implementation.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Trace(string message)
        {
            _logger.Verbose(message);
        }

        /// <summary>
        /// Logs a trace/verbose message using the current logger implementation.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        /// /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Trace(string message, object?[] args)
        {
            _logger.Verbose($"{message} {args}");
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Warn(string message)
        {
            _logger.Warning(message);
        }

        /// <summary>
        /// Logs a formatted warning message.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Warn(string message, object?[] args)
        {
            _logger.Warning($"{message} {args}");
        }
    }
}
