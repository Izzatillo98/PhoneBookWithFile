using Microsoft.EntityFrameworkCore;
using PhoneBookWithFile.Models;
using STX.EFxceptions.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    public class FileServiceV2 :EFxceptionsContext, IFileServiceV2    
         
    {
        public FileServiceV2()
        {
            this.Database.Migrate();

        }
        public DbSet<Contact> Contacts { get; set; }
        public async Task<Contact> AddContactAsync(Contact contact)
        {
            FileServiceV2 fileServiceV2 = new FileServiceV2();
            await fileServiceV2.Contacts.AddAsync(contact);
            await fileServiceV2.SaveChangesAsync();

            return contact;
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connetionResult = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PhoneBookApiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connetionResult);
        }
    }
}
