﻿using System;
namespace BankAccount
{
    public class Transaction
    {
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }

        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }
    }
}
