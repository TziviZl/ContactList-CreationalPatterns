using DesignPattern.PrototypeFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class PhoneContact:Contact, IPrototype
    {
        public PhoneContact(string name, string phoneNumber):base(name,phoneNumber) 
        {
            
        }
        public PhoneContact(PhoneContact phoneContact) : base(phoneContact)
        {

        }

        public PhoneContact(Group group):base(group)
        {
           
        }
        public IPrototype Clone()
        {
            return new PhoneContact(this);
        }
    }
}
