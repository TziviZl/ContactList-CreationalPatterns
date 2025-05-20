using DesignPattern.SingletonFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderFolder
{
    internal class SimContactBuilder:IContactBuilder
    {

        SimContact simContact;

        public Contact Reset(string _name, string phoneNumber)
        {
            simContact = new SimContact(_name, phoneNumber);
            PrettyPrint prettyPrint = new PrettyPrint();
            prettyPrint.Print(simContact, "Created in Sim builder");
            return simContact;

        }
        public void Birthday(string date)
        {
            simContact.Properties["Birthday"] = date;
        }
        public void Color(string color)
        {
            simContact.Properties["Color"] = "DarkGray";
        }
        public void Mail(string email)
        {
            simContact.Properties["Mail"] = email;
        }
        public void Sound(string sound)
        {
            simContact.Properties["Sound"] = sound;
        }
        public Contact GetContact()
        {
            return simContact;
        }
    }
}
