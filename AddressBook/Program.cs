using System.Diagnostics.Contracts;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            ContactDetails contacts = new ContactDetails();
            Contacts contact = new Contacts();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)Add Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contacts.AddingPerson(contact);
                        contacts.Display();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}