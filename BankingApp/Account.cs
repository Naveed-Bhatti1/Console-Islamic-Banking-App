using System;
using System.Collections.Generic;
using System.Transactions;

namespace ConsoleBankingApp
{
    class Account
    {
        public string AccountType { get; set; }      // e.g., Savings, Current, Investment
        public decimal Balance { get; set; } = 0;    // Initial balance
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
