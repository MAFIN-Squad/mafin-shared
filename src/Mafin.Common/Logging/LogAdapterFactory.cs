namespace Mafin.Common.Logging
{
    /// <summary>
    /// Factory class for creating instances of different logger types based on the provided "type" parameter.
    /// </summary>
    public class LogAdapterFactory
    {
        /// <summary>
        /// Creates a new instance of a specific logger type based on the provided "type" parameter.
        /// </summary>
        /// <param name="type">The type of logger to create. Could be "Console", "NLog", "Log4Net", "Serilog", or "MicrosoftLog".</param>
        /// <returns>Returns an instance of a logger type based on the provided parameter, or throws an exception if an invalid parameter is provided.</returns>
        /// <exception cref="System.ArgumentException">Thrown when an unrecognised "type" parameter is provided.</exception>
        public ILog CreateLogger(string type)
        {
            switch (type)
            {
                case "Console":
                    return new ConsoleAdapter();
                case "NLog":
                    return new NLogAdapter();
                case "Log4Net":
                    return new Log4NetAdapter();
                case "Serilog":
                    return new SerilogAdapter();
                case "MicrosoftLog":
                    return new MicrosoftLogAdapter();
                default:
                    throw new ArgumentException("Invalid logger type specified.");
            }
        }
    }
}
