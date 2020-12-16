using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace AddressBookProblem
{
    public class JSonOperation
    {
        string filePath = @"G:\Capgemini\LocalAddressBook\AddressBook\AddressBookProblem\AddressBookProblem\Utility\AddressBookRecord.json";
        public void WriteToFile(Dictionary<string, AddressBookBuilder> addressBookDictionary)
        {
            string json = "";
            foreach (AddressBookBuilder obj in addressBookDictionary.Values)
            {
                foreach (Contacts contact in obj.addressBook.Values)
                {
                    json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json);
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of JSON File");
            var json = File.ReadAllText(filePath);
            Contacts contact = JsonConvert.DeserializeObject<Contacts>(json);
            Console.WriteLine(contact.ToString());
        }
    }
}