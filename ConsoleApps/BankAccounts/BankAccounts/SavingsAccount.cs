using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class SavingsAccount : BankAccount {

        decimal interestRate;

        public SavingsAccount(decimal initialDeposit, decimal hahaha, decimal interestRate) : base(initialDeposit,hahaha) {
            this.interestRate = interestRate;
        }
    
        public void AccrueInterest() {
            balance += balance * interestRate;
        }
    }
}
