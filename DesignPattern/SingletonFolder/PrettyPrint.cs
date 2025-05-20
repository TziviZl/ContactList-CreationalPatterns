using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonFolder
{
    internal class PrettyPrint
    {
        private static PrettyPrint printer;
        public static PrettyPrint Printer
        {
            get
            {
                if (printer == null)
                {
                    printer = new PrettyPrint();
                }
                return printer;
            }
        }
        public PrettyPrint()
        {
        }

        public void Print(Contact contact, string header)
        {
            Console.WriteLine(header);
            Console.WriteLine("********************************");
            if (contact != null)
            {

                if (contact.Properties.ContainsKey("Color") && contact.Properties["Color"] != null)
                {
                    ConsoleColor c;
                    if (Enum.TryParse(contact.Properties["Color"], out c))
                        Console.ForegroundColor = c;
                }
                Console.WriteLine(contact.ToString());

            }
            else
            {
                Console.WriteLine("Contact is not exist");
            }

            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
