using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderFolder
{
    internal interface IContactBuilder
    {
        public void Mail(string email);
        public void Birthday(string date);
        public void Sound(string sound);
        public Contact Reset(string _name, string phoneNumber);
        public void Color(string color);
        public Contact GetContact();
        

    }
}
