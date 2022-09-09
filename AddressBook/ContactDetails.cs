using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactDetails
    {
        public List<Contacts> People = new List<Contacts>();
        public void AddingPerson(Contacts contact)
        {
            Console.WriteLine("Enter the First name :");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last name :");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Address :");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter the City :");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter the State :");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter the Zip Code :");
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number :");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the Email :");
            contact.Email = Console.ReadLine(); 
            People.Add(contact);
        }
        public void Display()
        {
            foreach (Contacts contact in People)
            {
                Console.WriteLine("Person Information");
                Console.WriteLine("Name of person : " + contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Address of person is : " + contact.Address);
                Console.WriteLine("Name of City : " + contact.City);
                Console.WriteLine("Name of State :" + contact.State);
                Console.WriteLine("Zip Code:" + contact.Zip);
                Console.WriteLine("Email of person : " + contact.Email);
                Console.WriteLine("Phone Number of person : " + contact.PhoneNumber);
            }
        }
    }
}