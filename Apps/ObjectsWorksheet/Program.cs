namespace ObjectsWorksheet
{
    internal class Program
    {
        private List<Contact> contacts = new List<Contact>();
        void addContact(String nickname, int number)
        {
            Contact contact = new Contact(nickname, number);
            contacts.Add(contact);
        }

        String getContact(String nickname)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.nickname == nickname)
                {
                    return contact.ToString();
                }
            }
            return "No contact found";
        }

        void getAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts");
            }
            else
            {
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact.ToString());
                }
            }
        }


        static void Main(String[] args)
        {
            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Get Contact");
                Console.WriteLine("3. Display Contacts");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter nickname");
                        String nickname = Console.ReadLine();
                        Console.WriteLine("Enter number");
                        int number = Convert.ToInt32(Console.ReadLine());

                        program.addContact(nickname, number);
                        break;

                    case 2:
                        Console.WriteLine("Enter nickname");
                        String nickname2 = Console.ReadLine();
                        Console.WriteLine(program.getContact(nickname2));
                        break;

                    case 3:
                        program.getAllContacts();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

    }
}
