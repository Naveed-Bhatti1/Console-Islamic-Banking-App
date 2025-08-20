using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleBankingApp
{
    static class Auth
    {
        // Register new user
        public static void Register(List<User> users)
        {
            Console.WriteLine("\n--- User Registration ---");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            // Check if username exists
            if (users.Any(u => u.Username == username))
            {
                Console.WriteLine("Username already exists. Try again.");
                return;
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User newUser = new User
            {
                Username = username,
                Password = password
            };

            users.Add(newUser);
            Console.WriteLine($"User '{username}' registered successfully!");
        }

        // Login existing user
        public static User Login(List<User> users)
        {
            Console.WriteLine("\n--- User Login ---");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine($"Welcome, {user.Username}!");
                return user;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return null;
            }
        }
    }
}

