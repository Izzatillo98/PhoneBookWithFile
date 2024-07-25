using Newtonsoft.Json;
using PhoneBookWithFile.Models;
using System;
using System.IO;

class JsonService : Contact
{
    static void Json()
    {
        string name = "Tillo";
        string filePath = "../../../phonebook.JSON";
        string fileContent = File.ReadAllText(filePath);


        ADDContact contact = new ADDContact
        {
            Name = fileContent
        };

        string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
        Console.WriteLine(json);
    }        
}

