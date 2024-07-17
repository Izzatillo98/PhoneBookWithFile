using System;

namespace PhoneBookWithFile.Services
{
    internal class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}