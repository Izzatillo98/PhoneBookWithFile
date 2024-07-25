using PhoneBookWithFile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    internal class FileServiceV2 : IFileService
    {
        private const string filePath = "../../../phoneBook.txt";
        private ILoggingService log;

        public string AddContact(Contact contact)
        {
            string newContact = $"{contact.Name}, {contact.Phone}";
            File.AppendAllText(filePath, newContact + Environment.NewLine);
            return newContact;
        }       
    }
}
