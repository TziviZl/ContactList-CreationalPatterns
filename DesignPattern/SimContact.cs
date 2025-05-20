using DesignPattern.PrototypeFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class SimContact:Contact, IPrototype
    {
       
        public SimContact(string name, string phoneNumber) : base(name, phoneNumber)
        {
            this.Group = Group.general;
           // this.Properties["Color"] = "DarkGray";
        }
        public SimContact(SimContact simContact) : base(simContact)
        {

        }
        public SimContact(Group group) : base(group)
        {

        }

        public IPrototype Clone()
        {
            return new SimContact(this);
        }
    }
}
