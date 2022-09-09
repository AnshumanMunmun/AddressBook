using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactDetails
    {                                                       //created a list name People
        public List<Contacts> People = new List<Contacts>();
        public void AddingPerson(Contacts contact) //parameterised constructor with contact for Adding Person details
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
        public void Display() //parameterised constructor with contact for Display Person details
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
        public void Edit() //parameterised constructor with contact for Edit Person details
        {
            Console.WriteLine("Enter the first name to search person details : ");
            string name = Console.ReadLine();
            foreach (Contacts contact in People)
            {
                if (contact.FirstName == name)
                {
                    Console.WriteLine("Given First Name exists");
                    Console.WriteLine("choose the option to change the details : \n1) First Name\n2) Last Name\n3) Address\n4) City\n5) State\n6) Zip\n7) Email\n8) Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the First name : ");
                            string FirstName = Console.ReadLine();
                            contact.FirstName = FirstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the Last name : ");
                            string LastName = Console.ReadLine();
                            contact.LastName = LastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Address : ");
                            string Address = Console.ReadLine();
                            contact.Address = Address;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the City : ");
                            string City = Console.ReadLine();
                            contact.City = City;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the State : ");
                            string State = Console.ReadLine();
                            contact.State = State;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the Zip Code : ");
                            string Zip = Console.ReadLine();
                            contact.Zip = Zip;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the Email : ");
                            string Email = Console.ReadLine();
                            contact.Email = Email;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Console.ReadLine();
                            contact.PhoneNumber = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine("please choose correct options :");
                            break;
                    }
                }
            }
        }
        public void Delete() //parameterised constructor with contact for Delete Person details
        {
            Console.WriteLine("Enter the first name to search person details : ");
            string name = Console.ReadLine();
                foreach (Contacts contacts in People)
                if (contacts.FirstName == name)
                {
                    Console.WriteLine("Given First Name exists");
                    People.Remove(contacts);
                    Console.WriteLine("Contact Deleted successfully");
                    return;
                }
            Console.WriteLine("given name contact does not exists");
        }
    }
}