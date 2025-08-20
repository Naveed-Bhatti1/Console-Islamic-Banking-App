using System;
using System.Collections.Generic;

namespace ConsoleBankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to the Islamic Banking App ===");

            // List to store all users
            List<User> users = new List<User>();

            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Auth.Register(users);
                        break;
                    case "2":
                        User currentUser = Auth.Login(users);
                        if (currentUser != null)
                        {
                            AccountMenu.Show(currentUser);
                        }
                        break;
                    case "3":
                        exitApp = true;
                        Console.WriteLine("Thank you for using the app. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
