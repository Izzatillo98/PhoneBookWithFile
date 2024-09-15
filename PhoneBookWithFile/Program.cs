using PhoneBookWithFile.Models;
using PhoneBookWithFile.Services;
using System;
using System.Threading.Tasks;

namespace PhoneBookWithFile
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        { 
          FileServiceV2 fileServiceV2 = new FileServiceV2();

            Contact contact = new Contact();
            contact.Name = "Tillo";
            contact.Id = Guid.NewGuid();
            contact.Phone =  "2312";

            await fileServiceV2.AddContactAsync(contact);

          IFileService fileService = new TxtFileService();
          ILoggingService loggingService = new LoggingService();
        }
    }
}