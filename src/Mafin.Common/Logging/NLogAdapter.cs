namespace Mafin.Common.Logging
{
    /// <summary>
    /// Provides an NLog implementation for the <see cref="ILog"/> interface.
    /// </summary>
    public sealed class NLogAdapter : ILog
    {
        private readonly NLog.Logger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogAdapter"/> class.
        /// Initializes a new instance of the NLog logger.
        /// </summary>
        public NLogAdapter()
        {
            _logger = NLog.LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Debug(string message)
        {
            _logger.Debug(message);
        }

        /// <summary>
        /// Logs a debug message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Debug(string message, object?[] args)
        {
            _logger.Debug(message, args);
        }

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Error(string message)
        {
            _logger.Error(message);
        }

        /// <summary>
        /// Logs an error message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Error(string message, object?[] args)
        {
            _logger.Error(message, args);
        }

        /// <summary>
        /// Logs an information message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Info(string message)
        {
            _logger.Info(message);
        }

        /// <summary>
        /// Logs an informational message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Info(string message, object?[] args)
        {
            _logger.Info(message, args);
        }

        /// <summary>
        /// Logs a trace message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Trace(string message)
        {
            _logger.Trace(message);
        }

        /// <summary>
        /// Logs a trace message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Trace(string message, object?[] args)
        {
            _logger.Trace(message, args);
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void ILog.Warn(string message)
        {
            _logger.Warn(message);
        }

        /// <summary>
        /// Logs a warning message with the provided arguments.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Warn(string message, object?[] args)
        {
            _logger.Warn(message, args);
        }
    }
}
