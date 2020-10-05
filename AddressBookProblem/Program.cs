using System;
namespace AddressBookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address book problem!");
            AddressBookBuilder bookBuilder = new AddressBookBuilder();
            Console.WriteLine("Enter first name");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            String lastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            String address = Console.ReadLine();
            Console.WriteLine("Enter city");
            String city = Console.ReadLine();
            Console.WriteLine("Enter state");
            String state = Console.ReadLine();
            Console.WriteLine("Enter zip");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter phone No");
            String phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email");
            String email = Console.ReadLine();
            bookBuilder.AddContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            bookBuilder.DisplayContacts();
        }
    }
}
