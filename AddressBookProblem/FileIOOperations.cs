using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace AddressBookProblem
{
    public class FileIOOperations
    {
        private string filePath = @"G:\Capgemini\LocalAddressBook\AddressBook\AddressBookProblem\AddressBookProblem\Utility\AddressBookRecord.txt";
        public void WriteToFile(Dictionary<string, AddressBookBuilder> addressBookDictionary)
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            foreach (AddressBookBuilder addressBookobj in addressBookDictionary.Values)
            {
                foreach (Contacts contact in addressBookobj.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
    }
}