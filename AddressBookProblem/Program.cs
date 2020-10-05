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
            bookBuilder.AddContacts("Aniket", "Mukherjee", "Salt Lake", "Kolkata", "West Bengal", "700064", "9073074916", "aniketmukherjee@gmail.com");
            bookBuilder.AddContacts("Rahul", "Das", "Jadavpur", "Kolkata", "West Bengal", "700032", "9903309542", "rahuldas1996@gmail.com");
            bookBuilder.AddContacts("Sayan", "Sarkar", "Birati", "Kolkata", "West Bengal", "700059", "8902644616", "sayansarkar@gmail.com");
            bookBuilder.DisplayContacts();
            Console.WriteLine("Add the first name of the person whose contact you want to edit");
            String firstNameForEditing = Console.ReadLine();
            bookBuilder.EditContacts(firstNameForEditing);
            bookBuilder.DisplayContacts();
            Console.ReadKey();
        }
    }
}
