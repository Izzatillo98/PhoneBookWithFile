using PhoneBookWithFile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    internal class TxtFileService : IFileService
    {
        private ILoggingService loggingService;
        private const string filePath = "../../../phoneBook.txt";

        public TxtFileService()
        {
            this.loggingService = new LoggingService();
            CreateFileIfNotExists();
        }
        private static void CreateFileIfNotExists()
        {
           var isFileExists = File.Exists(filePath);
            if (isFileExists is false)
            {
                File.Create(filePath).Close();
            }
        }

        public string AddContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void AddName()
        {
            throw new NotImplementedException();
        }

        public void DeleteContact()
        {
            throw new NotImplementedException();
        }

        public void ReadContact()
        {
            throw new NotImplementedException();
        }

        public void ReadPhoneNumber()
        {
            throw new NotImplementedException();
        }

        public void UpdatePhoneNumber()
        {
            throw new NotImplementedException();
        }
    }
}
