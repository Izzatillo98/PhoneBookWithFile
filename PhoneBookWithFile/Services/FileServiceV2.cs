using PhoneBookWithFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    internal class FileServiceV2 : IFileServiceV2
        
        
        
         
    {
        public Task<Contact> AddContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> DeleteContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> SelectAllContactsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
