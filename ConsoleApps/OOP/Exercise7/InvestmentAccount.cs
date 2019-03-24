using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    abstract class InvestmentAccount
    {
        protected float balance;

        public float Balance
        {
            get { return balance; }
        }

        public virtual void AddMoney(float amount) {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Amount error!");
        }

        public abstract void UpdateBalance();

        public InvestmentAccount(float initialDeposit)
        {
            balance = initialDeposit;
        }
    }
    class SavingsAccount : InvestmentAccount {
        float interestRate;

        public override string ToString()
        {
            return "Savings Account Balance: " + balance;
        }

        public override void UpdateBalance()
        {
            balance = balance + balance * interestRate;
        }
        public SavingsAccount(float initialDeposit, float interestRate)
        : base(initialDeposit){
            this.interestRate = interestRate;
        }
    }

    class MutualFund : InvestmentAccount
    {
        float ServiceChargePercent = 0.01f;

        public override void UpdateBalance()
        {
            balance *= 1.06f;
        }

        public override string ToString()
        {
            return "Mutal Fund Balance: " + balance;
        }

        public override void AddMoney(float amount)
        {
            base.AddMoney(amount * (1 - ServiceChargePercent));
        }

        public MutualFund(float initialDeposit):base(initialDeposit) {
         
        }
    }

    class EmployerSponsoredAccount : MutualFund
    {
        public override string ToString()
        {
            return "Employer-Sponsored Account Balance: " + balance;
        }

        public EmployerSponsoredAccount(float initialDeposit):base(initialDeposit) {
          
        }

        public override void AddMoney(float amount)
        {
            base.AddMoney(amount*2);
        }
    }

}
