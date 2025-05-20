using DesignPattern.SingletonFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryFolder
{
    internal class SimContactFactory: ContactFactory
    {
        public override Contact CreatContact(string _name, string _phoneNumber)
        {
            SimContact simContact = new SimContact(_name, _phoneNumber);
            simContact.Properties["Color"] = "DarkGray";
            PrettyPrint prettyPrint = new PrettyPrint();
            prettyPrint.Print(simContact, "Created in Sim Factory");
            return simContact;
        }

    }
}
