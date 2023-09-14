namespace Mafin.Common.Logging
{
    /// <summary>
    /// Provides logging functionality with different levels of severity.
    /// </summary>
    public interface ILog
    {
        /// <summary>
        /// Logs a trace message.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        void Trace(string message);

        /// <summary>
        /// Logs a formatted trace message.
        /// </summary>
        /// <param name="message">Message format.</param>
        /// <param name="args">Arguments to format the message.</param>
        void Trace(string message, object?[] args);

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        void Debug(string message);

        /// <summary>
        /// Logs a formatted debug message.
        /// </summary>
        /// <param name="message">Message format.</param>
        /// <param name="args">Arguments to format the message.</param>
        void Debug(string message, object?[] args);

        /// <summary>
        /// Logs an informational message.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        void Info(string message);

        /// <summary>
        /// Logs a formatted informational message.
        /// </summary>
        /// <param name="message">Message format.</param>
        /// <param name="args">Arguments to format the message.</param>
        void Info(string message, object?[] args);

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        void Warn(string message);

        /// <summary>
        /// Logs a formatted warning message.
        /// </summary>
        /// <param name="message">Message format.</param>
        /// <param name="args">Arguments to format the message.</param>
        void Warn(string message, object?[] args);

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        void Error(string message);

        /// <summary>
        /// Logs a formatted error message.
        /// </summary>
        /// <param name="message">Message format.</param>
        /// <param name="args">Arguments to format the message.</param>
        void Error(string message, object?[] args);
    }
}
