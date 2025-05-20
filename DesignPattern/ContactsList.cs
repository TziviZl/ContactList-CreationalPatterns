using DesignPattern.FactoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class ContactsList
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact) {
            Contacts.Add(contact);
           }
        public void AddContact(ContactFactory creator, string name, string phoneNumber)
        {
            Contacts.Add(creator.CreatContact(name,phoneNumber));
        }
        
        public Contact GetContactByName(string name)
        {
            for (int i = 0; i < Contacts.Count; i++)
            {
                if (Contacts[i].Name == name)
                {
                    return Contacts[i];
                }
            }
            return null;
        }

        public Contact GetContactByNumber(string phoneNumber)
        {
            for (int i = 0; i < Contacts.Count; i++)
            {
                if (Contacts[i].PhoneNumber == phoneNumber)
                {
                    return Contacts[i];
                }
            }
            return null;
        }



    }
}
