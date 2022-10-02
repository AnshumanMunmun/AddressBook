using System.Diagnostics.Contracts;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            ContactDetails contacts = new ContactDetails(); //create a ContactDetails object
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)Add Contact \n2)Edit Contact \n3)Delete Contact \n4)Add Multiple Contacts");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contacts.AddingPerson(); //Show Adding Person contact Details by objectname and methodname
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
                    case 4:
                        Console.WriteLine("Please enter number of contacts you want to add : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        contacts.AddMultipleContacts(n);
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}