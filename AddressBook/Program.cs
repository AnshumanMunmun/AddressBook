using System.Diagnostics.Contracts;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            ContactDetails contacts = new ContactDetails(); //create a ContactDetails object
            Contacts contact = new Contacts(); //create a Conatacts object
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)Add Contact \n2)Edit Contact \n3)Delete Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contacts.AddingPerson(contact); //Show Adding Person contact Details by objectname and methodname
                        contacts.Display();
                        break;
                    case 2:
                        contacts.Edit();        // Show Editing Person contact Details by objectname and methodname
                        contacts.Display();
                        break;
                    case 3:
                        contacts.Delete();        // Show Deleting Person contact Details by objectname and methodname
                        contacts.Display();
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}