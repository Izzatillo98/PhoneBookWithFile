using PhoneBookWithFile.Models;

namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        void AddName();
       void ReadPhoneNumber();
        void UpdatePhoneNumber();
        void DeleteContact();
       string AddContact(Contact contact);
        void ReadContact();
    }
}
