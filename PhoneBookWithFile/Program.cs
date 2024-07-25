﻿using PhoneBookWithFile.Models;
using PhoneBookWithFile.Services;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           FileServiceV2 service = new FileServiceV2();
            Contact contact = new Contact();
            contact.Name = "Test";
            contact.Phone = "1234567890";
            service.AddContact(contact);
        }
    }
}