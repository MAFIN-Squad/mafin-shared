namespace Mafin.Common.Logging
{
    /// <summary>
    /// Provides a console logging implementation for the <see cref="ILog"/> interface.
    /// </summary>
    public sealed class ConsoleAdapter : ILog
    {
        /// <summary>
        /// Writes a debug level message to the console.
        /// </summary>
        /// <param name="message">The message to write.</param>
        void ILog.Debug(string message) => Console.WriteLine($"Debug: {message}");

        /// <summary>
        /// Writes a debug level message, with formatting arguments, to the console.
        /// </summary>
        /// <param name="message">The message format string.</param>
        /// <param name="args">The formatting arguments.</param>
        void ILog.Debug(string message, object?[] args) => Console.WriteLine($"Debug: {message} {args}");

        /// <summary>
        /// Writes an error level message to the console.
        /// </summary>
        /// <param name="message">The message to write.</param>
        void ILog.Error(string message) => Console.WriteLine($"Error: {message}");

        /// <summary>
        /// Writes an error level message, with formatting arguments, to the console.
        /// </summary>
        /// <param name="message">The message format string.</param>
        /// <param name="args">The formatting arguments.</param>
        void ILog.Error(string message, object?[] args) => Console.WriteLine($"Error: {message} {args}");

        /// <summary>
        /// Writes an info level message to the console.
        /// </summary>
        /// <param name="message">The message to write.</param>
        void ILog.Info(string message) => Console.WriteLine($"Info: {message}");

        /// <summary>
        /// Writes an info level message, with formatting arguments, to the console.
        /// </summary>
        /// <param name="message">The message format string.</param>
        /// <param name="args">The formatting arguments.</param>
        void ILog.Info(string message, object?[] args) => Console.WriteLine($"Info: {message} {args}");

        /// <summary>
        /// Writes a trace level message to the console.
        /// </summary>
        /// <param name="message">The message to write.</param>
        void ILog.Trace(string message) => Console.WriteLine($"Trace: {message}");

        /// <summary>
        /// Writes a trace level message, with formatting arguments, to the console.
        /// </summary>
        /// <param name="message">The message format string.</param>
        /// <param name="args">The formatting arguments.</param>
        void ILog.Trace(string message, object?[] args) => Console.WriteLine($"Trace: {message} {args}");

        /// <summary>
        /// Writes a warning level message to the console.
        /// </summary>
        /// <param name="message">The message to write.</param>
        void ILog.Warn(string message) => Console.WriteLine($"Warn: {message}");

        /// <summary>
        /// Writes a warning level message, with formatting arguments, to the console.
        /// </summary>
        /// <param name="message">The message format string.</param>
        /// <param name="args">The formatting arguments.</param>
        void ILog.Warn(string message, object?[] args) => Console.WriteLine($"Warn: {message} {args}");
    }
}
