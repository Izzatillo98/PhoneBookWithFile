using PhoneBookWithFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    internal interface IFileServiceV2 
    {

        Task<Contact> AddContactAsync(Contact contact);
        Task<List<Contact>> SelectAllContactsAsync();
        Task<Contact> UpdateContactAsync(Contact contact);
        Task<Contact> DeleteContactAsync(Contact contact);   


    }
}
