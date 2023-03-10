using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Programs");
            AddressBook addressBook = new AddressBook();

            Console.WriteLine("Enter firstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter lastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter phoneNumber");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter zip");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            //UC2-Add contact
            addressBook.addContact(firstName, lastName, email, phoneNumber, address, zip, city, state);
            //UC3-Edit contact
            Console.WriteLine("\nIf you want to edit contact plz enter firstName");
            string name = Console.ReadLine();
            addressBook.Edit(name);
            //UC4-Delete contact
            Console.WriteLine("\nIf you want to delete contact plz enter firstname");
            string firstname = Console.ReadLine();
            addressBook.Remove(firstname);
            Console.ReadLine();
        }
    }
}
