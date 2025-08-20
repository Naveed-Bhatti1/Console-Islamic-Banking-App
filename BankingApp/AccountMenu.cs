using System;

namespace ConsoleBankingApp
{
    static class AccountMenu
    {
        public static void Show(User user)
        {
            bool logout = false;

            while (!logout)
            {
                Console.WriteLine($"\n--- {user.Username}'s Account Menu ---");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. View Accounts & Balance");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Withdraw Money");
                Console.WriteLine("5. View Transaction History");
                Console.WriteLine("6. Logout");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AccountOperations.CreateAccount(user);
                        break;
                    case "2":
                        AccountOperations.ViewAccounts(user);
                        break;
                    case "3":
                        AccountOperations.Deposit(user);
                        break;
                    case "4":
                        AccountOperations.Withdraw(user);
                        break;
                    case "5":
                        AccountOperations.ViewTransactions(user);
                        break;
                    case "6":
                        logout = true;
                        Console.WriteLine("Logged out successfully.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
