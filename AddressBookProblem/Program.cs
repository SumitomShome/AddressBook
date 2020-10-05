using System;
namespace AddressBookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address book problem!");
            AddressBookBuilder bookBuilder = new AddressBookBuilder();
            bookBuilder.AddContacts("Sumitom", "Shome", "Ruby", "Kolkata", "West Bengal", "700107", "9433430056", "sumitomshome@gmail.com");
            bookBuilder.DisplayContacts();
        }
    }
}
