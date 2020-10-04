using System;
namespace AddressBookProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address book problem!");
            AddressBookBuilder bookBuilder = new AddressBookBuilder();
            bookBuilder.AddContacts("Sumitom", "Shome", "Ruby", "Kolkata", "West Bengal", 700107, "9433430056", "sumitomshome@gmail.com");
            bookBuilder.AddContacts("Aniket", "Mukherjee", "Salt Lake", "Kolkata", "West Bengal", 700064, "9073074916", "aniketmukherjee@gmail.com");
            bookBuilder.AddContacts("Rahul", "Das", "Jadavpur", "Kolkata", "West Bengal", 700032, "9903309542", "rahul1996das@gmail.com");
            bookBuilder.AddContacts("Steve", "Rogers", "Brooklyn", "New York", "New York", 11201, "9123456789", "steverogers@gmail.com");
            Console.ReadLine();
            bookBuilder.DisplayContacts();
        }
    }
}
