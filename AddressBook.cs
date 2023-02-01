using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Contact> contacts = new List<Contact>();
        public void addContact(string firstName, string email, string lastName, string phoneNumber, string address, string zip, string city, string state)
        {
            contacts.Add(new Contact()
            {
                firstName = firstName,
                lastName = lastName,
                email = email,
                phoneNo = phoneNumber,
                address = address,
                zip = zip,
                city = city,
                state = state,
            });
            Console.WriteLine($"Contact of {firstName}{lastName} has been added");
        }
    }
}
