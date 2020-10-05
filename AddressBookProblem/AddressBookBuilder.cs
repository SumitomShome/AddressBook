using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
namespace AddressBookProblem
{
    public class AddressBookBuilder
    {
       private Dictionary<string, Contacts> table = new Dictionary<string, Contacts>();
       public void AddContacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contacts contacts = new Contacts();
            contacts.FirstName = firstName;
            contacts.LastName = lastName;
            contacts.Address = address;
            contacts.City = city;
            contacts.State = state;
            contacts.Zip = zip;
            contacts.PhoneNumber = phoneNumber;
            contacts.Email = email;
            table.Add(contacts.FirstName, contacts);
        }
        public void DisplayContacts()
        {
            foreach(KeyValuePair<string, Contacts> item in table)
            {
                Console.WriteLine("First Name: " + item.Value.FirstName);
                Console.WriteLine("Last Name: " + item.Value.LastName);
                Console.WriteLine("Address: " + item.Value.Address);
                Console.WriteLine("City: " + item.Value.City);
                Console.WriteLine("State: " + item.Value.State);
                Console.WriteLine("Zip: " + item.Value.Zip);
                Console.WriteLine("Phone number: " + item.Value.PhoneNumber);
                Console.WriteLine("Email: " + item.Value.Email);
            }
         }
       public void EditContacts(String firstNameForEditing)
        {
            table.Remove(firstNameForEditing);
            Console.WriteLine("Enter first name: ");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            String lastName = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            String address = Console.ReadLine();
            Console.WriteLine("Enter city: ");
            String city = Console.ReadLine();
            Console.WriteLine("Enter state: ");
            String state = Console.ReadLine();
            Console.WriteLine("Enter zip: ");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            String phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            String email = Console.ReadLine();
            AddContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
        }
     }
}
