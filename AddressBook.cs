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
        //UC2-Add contact
        public void addContact(string firstName, string lastName, string email, string phoneNumber, string address, string zip, string city, string state)
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
            Console.WriteLine($"Contact of {firstName} {lastName} has been added");
        }
        //UC3-Edit contact
        public void Edit(string name)
        {
            Contact editContact = null;
            foreach (var contact in contacts)
            {
                if (contact.firstName.Contains(name))
                {
                    editContact = contact;
                }
            }

            Console.WriteLine("Plz provide new firstName");
            editContact.firstName = Console.ReadLine();
            Console.WriteLine("Plz provide new lastName");
            editContact.lastName = Console.ReadLine();
            Console.WriteLine("Plz provide new email");
            editContact.email = Console.ReadLine();
            Console.WriteLine("Plz provide new phoneNumber");
            editContact.phoneNo = Console.ReadLine();
            Console.WriteLine("Plz provide new address");
            editContact.address = Console.ReadLine();
            Console.WriteLine("Plz provide new zip");
            editContact.zip = Console.ReadLine();
            Console.WriteLine("Plz provide new city");
            editContact.city = Console.ReadLine();
            Console.WriteLine("Plz provide new state");
            editContact.state = Console.ReadLine();

            contacts.Add(editContact);
            Console.WriteLine($"Contact of {name} has been edited");
        }
        //UC4-Delete contact
        public void Remove(string name)
        {
            Contact RemoveContact = null;
            foreach (var contact in contacts)
            {
                if (contact.firstName.Contains(name))
                {
                    RemoveContact = contact;
                }
            }
            contacts.Remove(RemoveContact);
            Console.WriteLine($"Contact of {name} has been deleted");
        }
    }
}
