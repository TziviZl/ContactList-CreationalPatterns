using DesignPattern;
using DesignPattern.BuilderFolder;
using DesignPattern.FactoryFolder;
using DesignPattern.PrototypeFolder;
using DesignPattern.SingletonFolder;
using Microsoft.Win32;
using System;
using System.Linq.Expressions;

PhoneContactFactory phoneFactory = new PhoneContactFactory();
SimContactFactory simFactory = new SimContactFactory();
PrototypeRegistry registry = new PrototypeRegistry();
PhoneContactBuilder phoneBuilder = new PhoneContactBuilder();
SimContactBuilder simBuilder = new SimContactBuilder();
ContactDirector phoneDirector = new ContactDirector(phoneBuilder);
ContactDirector simDirector = new ContactDirector(simBuilder);
ContactsList contactsList = new ContactsList();
PrettyPrint prettyPrint = new PrettyPrint();

Contact david = phoneFactory.CreatContact("David", "0548546985");
Contact dan = phoneFactory.CreatContact("Dan", "0587454789");
Contact chaim = simFactory.CreatContact("Chaim", "0556547896");
Contact ovad = simFactory.CreatContact("Ovad", "0526547896");

Contact yossef = phoneBuilder.Reset("Yossef", "0542123654");
yossef.Group = Group.Friends;
yossef.Properties["Color"] = "Red";

Contact lev = phoneDirector.BasicContact("Lev", "0562542569", "Yellow", "la la la").GetContact();
Contact shulem = simDirector.BasicContact("Shulem", "0542585658", "01/01/2020").GetContact();

Contact tal = (Contact)registry.GetContact(Group.Family);
tal.Name = "Tal";
tal.PhoneNumber = "05562654789";
tal.Properties["Birthday"] = "7th September";

Contact aviv = (Contact)registry.GetContact(Group.Job);
aviv.Name = "Aviv";
aviv.PhoneNumber = "0562587589";
aviv.Properties["Mail"] = "Aviv@gmail.com";

Contact steve = (Contact)registry.GetContact(Group.Friends);
steve.Name = "Steve";
steve.PhoneNumber = "0526545698";
steve.Properties["Color"] = "DarkBlue";
steve.Properties["Birthday"] = "12th July";

Contact sam = (Contact)registry.GetContact(Group.general);
sam.Name = "Sam";
sam.PhoneNumber = "0565896542";
sam.Properties["Sound"] = "tri li lai";


contactsList.Contacts.Add(david);
contactsList.Contacts.Add(dan);
contactsList.Contacts.Add(chaim);
contactsList.Contacts.Add(ovad);
contactsList.Contacts.Add(yossef);
contactsList.Contacts.Add(lev);
contactsList.Contacts.Add(shulem);
contactsList.Contacts.Add(tal);
contactsList.Contacts.Add(aviv);
contactsList.Contacts.Add(steve);
contactsList.Contacts.Add(sam);

string option = "";
while (option != "-1")
{
    Console.WriteLine("Press 1 to search a contact by name");
    Console.WriteLine("Press 2 to search a contact by number");
    Console.WriteLine("Press 3 to view all the contacts");
    Console.WriteLine("Press -1 to finish");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Insert the name");
            string name = Console.ReadLine();
            prettyPrint.Print(contactsList.GetContactByName(name), name);
            break;
        case "2":
            Console.WriteLine("Insert the number");
            string number = Console.ReadLine();
            prettyPrint.Print(contactsList.GetContactByNumber(number), number);
            break;
        case "3":
            foreach (Contact contact in contactsList.Contacts)
            {
                prettyPrint.Print(contact, contact.Name);
            }
            break;
        default:
            Console.WriteLine("Insert a valid option");
            break;
    }
}


