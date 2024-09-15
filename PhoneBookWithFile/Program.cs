using PhoneBookWithFile.Models;
using PhoneBookWithFile.Services;

namespace PhoneBookWithFile
{
    internal class Program
    {
        private static object Service;

        static void Main(string[] args)
        { 
           IFileService fileService = new TxtFileService();
           ILoggingService loggingService = new LoggingService();
        }
    }
}