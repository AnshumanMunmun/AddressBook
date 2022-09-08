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
        public void AddingPerson()
        {
            Contacts contact = new Contacts()
            {
                FirstName = "Anshuman",
                LastName = "Purohit",
                Address = "Bhawanipura",
                City = "Pokaran",
                State = "Rajasthan",
                Zip = "345021",
                PhoneNumber = "9664436051",
                Email = "imanshuman47@gmail.com"
            };
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
