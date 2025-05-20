using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeFolder
{
    internal class PrototypeRegistry
    {
        List<IPrototype> Prototypes = new List<IPrototype>();
        public PrototypeRegistry()
        {
            Prototypes.Add(new PhoneContact(Group.Friends) { Properties = { ["Color"] = "ConsoleColor.DarkBlue", ["Birthday"] = null } });
            Prototypes.Add(new PhoneContact(Group.Job) { Properties = { ["Mail"] = null } });
            Prototypes.Add(new PhoneContact(Group.Family) { Properties = { ["Birthday"] = null } });
            Prototypes.Add(new SimContact(Group.general) { Properties = { ["Sound"] = null } });


        }

        public IPrototype GetContact(Group group)
        {
            return Prototypes.First(x => ((Contact)x).Group == group)?.Clone();
        }
    }
}
