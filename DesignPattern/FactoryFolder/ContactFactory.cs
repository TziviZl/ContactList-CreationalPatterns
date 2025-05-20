using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryFolder
{
    internal abstract class ContactFactory
    {
        public abstract Contact CreatContact(string _name, string _phoneNumber);
    }
}
