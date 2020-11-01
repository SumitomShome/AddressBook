using System;
using System.Collections.Generic;
namespace AddressBookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookBuilder bookBuilder = new AddressBookBuilder();
            Console.WriteLine("Welcome to the address book problem!");
            Console.WriteLine("Please enter number of names you want to enter: ");
            int input = Console.Read();
            for (int i = 0; i <= input; i++)
            {
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
                bookBuilder.AddContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
                bookBuilder.DisplayContacts();
            }
            bookBuilder.DisplayContacts();
            Console.WriteLine("Add the first name of the person whose contact you want to delete");
            String firstNameForDeleting = Console.ReadLine();
            bookBuilder.DeleteContacts(firstNameForDeleting);
            bookBuilder.DisplayContacts();
            Console.ReadKey();
        }
    }
}
