using PhoneBookWithFile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    internal class FileServiceV2 : Contact
    {
        private const string filePath = "../../../phoneBook.JSON";
        private ILoggingService log;

        public void AddContact(Contact contact)
        {
            string newContact = $"{contact.Name}, {contact.Phone}";
            File.AppendAllText(filePath, newContact + Environment.NewLine);
        }
    }
}
