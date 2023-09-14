using Microsoft.Extensions.Logging;

namespace Mafin.Common.Logging
{
    /// <summary>
    /// Provides a Microsoft.Extensions.Logging implementation for the <see cref="ILog"/> interface.
    /// </summary>
    public sealed class MicrosoftLogAdapter : ILog
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="MicrosoftLogAdapter"/> class.
        /// Creates a new instance of the Microsoft.Extensions.Logging logger.
        /// </summary>
        public MicrosoftLogAdapter()
        {
            _logger = new LoggerFactory().CreateLogger("Log");
        }

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <param name="message">The message to be logged</param>
        void ILog.Debug(string message)
        {
            _logger.LogDebug(message);
        }

        /// <summary>
        /// Logs a debug message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Debug(string message, object?[] args)
        {
            _logger.LogDebug(message, args);
        }

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Error(string message)
        {
            _logger.LogError(message);
        }

        /// <summary>
        /// Logs an error message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Error(string message, object?[] args)
        {
            _logger.LogError(message, args);
        }

        /// <summary>
        /// Logs an information message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Info(string message)
        {
            _logger.LogInformation(message);
        }

        /// <summary>
        /// Logs an information message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Info(string message, object?[] args)
        {
            _logger.LogInformation(message, args);
        }

        /// <summary>
        /// Logs a trace message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Trace(string message)
        {
            _logger.LogTrace(message);
        }

        /// <summary>
        /// Logs a trace message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Trace(string message, object?[] args)
        {
            _logger.LogTrace(message, args);
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Warn(string message)
        {
            _logger.LogWarning(message);
        }

        /// <summary>
        /// Logs a warning message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Warn(string message, object?[] args)
        {
            _logger.LogWarning(message, args);
        }
    }
}
