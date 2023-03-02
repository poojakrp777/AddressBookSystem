using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public interface IContacts
    {
        public void AddContact(string firstName, string lastName, string email, long phoneNumber, string address, int zip, string city, string state);
        public void Edit(string Name);
        public void Remove(string name);
    }
}