namespace Mafin.Common.Logging
{
    /// <summary>
    /// Provides a Log4Net implementation for the <see cref="ILog"/> logging interface.
    /// </summary>
    public sealed class Log4NetAdapter : ILog
    {
        private readonly log4net.ILog _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4NetAdapter"/> class.
        /// Creates a new Log4Net logger.
        /// </summary>
        public Log4NetAdapter()
        {
            _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void ILog.Debug(string message)
        {
            _logger.Debug(message);
        }

        /// <summary>
        /// Logs a formatted debug message.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Debug(string message, object?[] args)
        {
            _logger.DebugFormat(message, args);
        }

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void ILog.Error(string message)
        {
            _logger.Error(message);
        }

        /// <summary>
        /// Logs a formatted error message.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Error(string message, object?[] args)
        {
            _logger.ErrorFormat(message, args);
        }

        /// <summary>
        /// Logs an info message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void ILog.Info(string message)
        {
            _logger.Info(message);
        }

        /// <summary>
        /// Logs a formatted info message.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Info(string message, object?[] args)
        {
            _logger.InfoFormat(message, args);
        }

        /// <summary>
        /// Logs a trace message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void ILog.Trace(string message)
        {
            _logger.Info(message);
        }

        /// <summary>
        /// Logs a formatted trace message.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Trace(string message, object?[] args)
        {
            _logger.InfoFormat(message, args);
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void ILog.Warn(string message)
        {
            _logger.Warn(message);
        }

        /// <summary>
        /// Logs a formatted warning message.
        /// </summary>
        /// <param name="message">The formatted message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        void ILog.Warn(string message, object?[] args)
        {
            _logger.WarnFormat(message, args);
        }
    }
}
