using System;

namespace ConsoleBankingApp
{
    class Transaction
    {
        public string Type { get; set; }      // Deposit, Withdrawal, Transfer
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Note { get; set; }      // Optional description
    }
}
