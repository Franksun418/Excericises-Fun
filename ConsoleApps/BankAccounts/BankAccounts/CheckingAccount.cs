using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class CheckingAccount : BankAccount {
        public List<decimal> checks = new List<decimal>();

        public List<decimal> Checks {
            get { return checks; }
        }

        public void CashCheck(decimal amount) {
            if (amount < balance)
            {
                balance -= amount;
                checks.Add(amount);
            }
            else
                Console.WriteLine("You have no enough money to cover check.");
        }

        public CheckingAccount(decimal initialDeposit) : base(initialDeposit) {

        }
    }
}
