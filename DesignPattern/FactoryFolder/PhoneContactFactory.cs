using DesignPattern.SingletonFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryFolder
{
    internal class PhoneContactFactory: ContactFactory
    {
        public override Contact CreatContact(string _name, string _phoneNumber)
        {
            PhoneContact phoneContact = new PhoneContact(_name, _phoneNumber);
            PrettyPrint prettyPrint = new PrettyPrint();
            prettyPrint.Print(phoneContact, "Created in Phone Factory");
            return phoneContact;
        }

    }
}
