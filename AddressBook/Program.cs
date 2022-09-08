namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            ContactDetails contacts = new ContactDetails();
            contacts.AddingPerson();
        }
    }
}