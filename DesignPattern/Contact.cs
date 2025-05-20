using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Group Group { get; set; }

        public Dictionary<string, string> Properties { get; set; }

        public Contact(string name, string phoneNumber, Group group)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Group = group;     
            Properties = new Dictionary<string, string>();
        }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;           
            Properties = new Dictionary<string, string>();
        }


        public Contact(Contact contact)
        {
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Group = contact.Group;
            Properties = contact.Properties;
            
        }

        public Contact(Group group)
        {
            Group = group;
            Properties = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            string s = $"{"Name",-15}: {Name,-15} \n";
            foreach (var item in Properties)
            {
                s += $"{item.Key,-15}: {item.Value,-15}\n";
            }
            return s;
        }


    }
}
