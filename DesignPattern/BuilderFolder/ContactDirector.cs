using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderFolder
{
    internal class ContactDirector
    {
        IContactBuilder _contactBuilder;
        public ContactDirector(IContactBuilder contactBuilder)
        {
            _contactBuilder = contactBuilder;
        }

        public void ChangeBuilder(IContactBuilder contactDirector)
        {
           _contactBuilder = contactDirector;
        }

        public IContactBuilder BasicContact(string name, string phoneNumber, string color, string sound)
        {
            _contactBuilder.Reset(name, phoneNumber); 
            _contactBuilder.Color(color);
            _contactBuilder.Sound(sound);
            return _contactBuilder;
        }

        public IContactBuilder BasicContact(string name, string phoneNumber, string birthday)
        {
            _contactBuilder.Reset(name, phoneNumber);
            _contactBuilder.Birthday(birthday);
            return _contactBuilder;
        }

        public Contact GetContact()
        {
            return _contactBuilder.GetContact();
        }


    }

}
