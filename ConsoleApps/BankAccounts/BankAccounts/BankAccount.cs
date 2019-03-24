using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class BankAccount
    {
        protected decimal balance;

        List<Decimal> deposits = new List<decimal>();
        List<Decimal> withdrawals = new List<decimal>();

        public BankAccount(decimal initialDeposit,decimal hahaha)
        {
            balance = initialDeposit;
            deposits.Add(initialDeposit);
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public List<Decimal> Deposits
        {
            get { return deposits; }
        }

        public List<Decimal> Withdrawals
        {
            get { return withdrawals; }
        }

        public void MakeDeposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                deposits.Add(amount);
            }
            else
            {
                Console.WriteLine("You cannot deposit air to your account!");
            }

        }

        public void MakeWithdrawal(decimal amount)
        {
            if (balance > 0&& amount<=balance)
            {
                balance -= amount;
                withdrawals.Add(amount);
            }
            else
            {
                Console.WriteLine("You a freaking poor guy!");
            }
        }

        public override string ToString()
        {
            return "Balance:" + balance;
        }
    }
}
