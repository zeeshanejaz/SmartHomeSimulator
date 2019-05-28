using System;

namespace SmartHomeSimulator.Log
{
    internal class LoggedException : Exception
    {
        public LoggedException(string message)
        : base(message)
        {
        }

        public LoggedException(string format, params object[] parameters)
            : base(string.Format(format, parameters))
        {
        }
    }
}
