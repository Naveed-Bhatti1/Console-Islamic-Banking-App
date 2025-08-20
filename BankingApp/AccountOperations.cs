using System;
using System.Linq;

namespace ConsoleBankingApp
{
    static class AccountOperations
    {
        // Create a new account
        public static void CreateAccount(User user)
        {
            Console.WriteLine("\n--- Create New Account ---");
            Console.Write("Enter account type (Savings / Current / Investment): ");
            string type = Console.ReadLine();

            Account newAccount = new Account
            {
                AccountType = type,
                Balance = 0
            };

            user.Accounts.Add(newAccount);
            Console.WriteLine($"Account '{type}' created successfully!");
        }

        // View all accounts and balances
        public static void ViewAccounts(User user)
        {
            Console.WriteLine("\n--- Your Accounts ---");
            if (user.Accounts.Count == 0)
            {
                Console.WriteLine("No accounts found. Create one first.");
                return;
            }

            for (int i = 0; i < user.Accounts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {user.Accounts[i].AccountType} - Balance: {user.Accounts[i].Balance} USD");
            }
        }

        // Deposit money
        public static void Deposit(User user)
        {
            if (user.Accounts.Count == 0)
            {
                Console.WriteLine("No accounts found. Create one first.");
                return;
            }

            ViewAccounts(user);
            Console.Write("Select account number to deposit into: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index < 0 || index >= user.Accounts.Count)
            {
                Console.WriteLine("Invalid account selection.");
                return;
            }

            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            user.Accounts[index].Balance += amount;
            user.Accounts[index].Transactions.Add(new Transaction
            {
                Type = "Deposit",
                Amount = amount,
                Note = "Deposit via console app"
            });

            Console.WriteLine($"Deposited {amount} USD into {user.Accounts[index].AccountType} account.");
        }

        // Withdraw money
        public static void Withdraw(User user)
        {
            if (user.Accounts.Count == 0)
            {
                Console.WriteLine("No accounts found. Create one first.");
                return;
            }

            ViewAccounts(user);
            Console.Write("Select account number to withdraw from: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index < 0 || index >= user.Accounts.Count)
            {
                Console.WriteLine("Invalid account selection.");
                return;
            }

            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount > user.Accounts[index].Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            user.Accounts[index].Balance -= amount;
            user.Accounts[index].Transactions.Add(new Transaction
            {
                Type = "Withdrawal",
                Amount = amount,
                Note = "Withdrawal via console app"
            });

            Console.WriteLine($"Withdrew {amount} USD from {user.Accounts[index].AccountType} account.");
        }

        // View transaction history
        public static void ViewTransactions(User user)
        {
            if (user.Accounts.Count == 0)
            {
                Console.WriteLine("N
