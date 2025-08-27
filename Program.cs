using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace telephonedairy1
{
    static class Program
    {


        struct Contact
        {
            public string Name;
            public string LastName;
            public string PhoneNumber;
            public string Address;
            public string City;
            public string Email;
        }
        // static (OR) Global variables declared
        static Contact[] contacts = new Contact[100];         // array decleared
        static int contactCount = 0;                         // contactcount decleared


        static void AddContact()
        {
            string text1 = "Enter contact first name:";
            string[] words1 = text1.Split(' ');

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(words1[0] + " ");
            Console.Write(words1[1] + " ");

            // for loop is used to change the colour of all remaining words
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 2; i < words1.Length; i++)   // i represent the index of array which is 2
            {
                Console.Write(words1[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            contacts[contactCount].Name = Console.ReadLine();   // [contactCount].Name is used to represent index of array which is contacts
            //---------------------------------------------------------------------------
            string text2 = "Enter contact last name:";
            string[] words2 = text2.Split(' ');

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(words2[0] + " ");
            Console.Write(words2[1] + " ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 2; i < words2.Length; i++)
            {
                Console.Write(words2[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            contacts[contactCount].LastName = Console.ReadLine();
            //---------------------------------------------------------------------------
            string text4 = "Enter phone number:";
            string[] words4 = text4.Split(' ');

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(words4[0] + " ");
            Console.Write(words4[1] + " ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 2; i < words4.Length; i++)
            {
                Console.Write(words4[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            contacts[contactCount].PhoneNumber = Console.ReadLine();
            //-------------------------------------------------------------------------
            string text5 = "Enter contact Address: ";
            string[] words5 = text5.Split(' ');

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(words5[0] + " ");
            Console.Write(words5[1] + " ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 2; i < words5.Length; i++)
            {
                Console.Write(words5[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            contacts[contactCount].Address = Console.ReadLine();
            //-------------------------------------------------------------------------
            string text6 = "Enter contact City:";
            string[] words6 = text6.Split(' ');

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(words6[0] + " ");
            Console.Write(words6[1] + " ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 2; i < words6.Length; i++)
            {
                Console.Write(words6[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            contacts[contactCount].City = Console.ReadLine();
            //-------------------------------------------------------------------------
            string text7 = "Enter your Email:";
            string[] words7 = text7.Split(' ');

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(words7[0] + " ");
            Console.Write(words7[1] + " ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 2; i < words7.Length; i++)
            {
                Console.Write(words7[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            contacts[contactCount].Email = Console.ReadLine();
            //-------------------------------------------------------------------------
            contactCount++;  // increment in index of array after adding a contact
            Console.WriteLine("Contact added successfully!");
        }

        static void ViewContacts()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Contacts:");
            for (int i = 0; i < contactCount; i++)
            {
                Console.WriteLine($"Name: {contacts[i].Name}, Last Name: {contacts[i].LastName} Phone: {contacts[i].PhoneNumber} Address: {contacts[i].Address} City: {contacts[i].City} Email: {contacts[i].Email}");
            }
            Console.ResetColor();
        }

        static void SearchContact()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter search term: ");
            string searchTerm = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].Name.Contains(searchTerm) || contacts[i].LastName.Contains(searchTerm) || contacts[i].PhoneNumber.Contains(searchTerm) || contacts[i].Address.Contains(searchTerm) || contacts[i].City.Contains(searchTerm) || contacts[i].Email.Contains(searchTerm))
                {
                    Console.WriteLine($"Name: {contacts[i].Name}, Last Name: {contacts[i].LastName} Phone: {contacts[i].PhoneNumber} Address: {contacts[i].Address} City: {contacts[i].City} Email: {contacts[i].Email}");
                    found = true;    //  if the matching contact found, fond is set true to indicate at least one matching contact.
                }
            }
            if (!found)
            {
                Console.WriteLine("No matching contacts found.");
            }
            Console.ResetColor();
        }

        static void DeleteContact()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter the name of the contact to delete: ");
            string contactName = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].Name.Equals(contactName, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < contactCount - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }
                    contactCount--;
                    found = true;
                    Console.WriteLine("Contact deleted successfully!");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact not found.");
            }
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\t[Project name: TelePhone Diary]\n");
            Console.WriteLine("\t\t\t\t\t\t(Programmers)\n \t\t\t\t\t\t M. Adnan Arif \n \t\t\t\t\t\t Rizwan Khan\n\t\t\t\t\t\tMudeer Ali");
            Console.ForegroundColor = ConsoleColor.Red;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Telephone Diary");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                Console.ForegroundColor = ConsoleColor.White;
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContact();  // calling addcontact function
                        break;
                    case 2:
                        ViewContacts();   // calling  ViewContacts function
                        break;
                    case 3:
                        SearchContact();    // calling  SearchContact function
                        break;
                    case 4:
                        DeleteContact();    // calling  DeleteContact function
                        break;
                    case 5:
                        Console.WriteLine("Exiting Telephone Diary. Goodbye!");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }
            } while (true);
        }

    }


}