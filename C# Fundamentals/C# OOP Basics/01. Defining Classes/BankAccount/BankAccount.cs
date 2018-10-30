using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            if (balance >= 0)
            {
                balance -= amount;

                return amount;
            }

            throw new ArgumentException("Insufficient Balance!");
        }

        public override string ToString()
        {
            return $"Your balance: {balance}";
        }
    }
}
