using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook : IContacts
    {
        List<Contact> contacts = new List<Contact>();
        //UC2-Add contact
        public void AddContact(string firstName, string lastName, string email, long phoneNumber, string address, int zip, string city, string state)
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
            Console.WriteLine("Select options to Edit Details :\n" +"1.First_Name\n"+"2.Last_Name\n" + "3.Address\n" + "4.city\n" +"5.state\n" + " 6.zip Code\n" + "7.Phone Number\n" + "8.Email\n");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Plz provide new firstName");
                    editContact.firstName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Plz provide new lastName");
                    editContact.lastName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Plz provide new email");
                    editContact.email = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Plz provide new phoneNumber");
                    editContact.phoneNo = Convert.ToInt64(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Plz provide new address");
                    editContact.address = Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Plz provide new zip");
                    editContact.zip = Convert.ToInt32(Console.ReadLine());
                    break;
                case 7:
                    Console.WriteLine("Plz provide new city");
                    editContact.city = Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("Plz provide new state");
                    editContact.state = Console.ReadLine();
                    break;
            }
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
