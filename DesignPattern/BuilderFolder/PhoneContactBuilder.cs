using DesignPattern.SingletonFolder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderFolder
{
    internal class PhoneContactBuilder : IContactBuilder
    {
        PhoneContact phoneContact;

        public Contact Reset(string _name, string phoneNumber)
        {
            phoneContact = new PhoneContact(_name, phoneNumber);
            PrettyPrint prettyPrint = new PrettyPrint();
            prettyPrint.Print(phoneContact, "Created in Phone builder");
            return phoneContact;
        }

        public void Group(Group group)
        {
            phoneContact.Group = group;
        }
        public void Birthday(string date)
        {
            phoneContact.Properties["Birthday"] = date;
        }

        public void Color(string color)
        {
            phoneContact.Properties["Color"] = color;
        }

        public void Mail(string email)
        {
            phoneContact.Properties["Mail"] = email;
        }

        public void Sound(string sound)
        {
            phoneContact.Properties["Sound"] = sound;
        }
        public Contact GetContact()
        {
            return phoneContact;
        }
    }
}
