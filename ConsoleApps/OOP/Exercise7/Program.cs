using System;
using System.Collections.Generic;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<InvestmentAccount> investmentAccounts = new List<InvestmentAccount>();
            investmentAccounts.Add(new SavingsAccount(100f, 0.03f));
            investmentAccounts.Add(new MutualFund(100f));
            investmentAccounts.Add(new EmployerSponsoredAccount(100f));

            foreach (InvestmentAccount account in investmentAccounts)
            {
                Console.WriteLine(account);
            }


            foreach (InvestmentAccount account in investmentAccounts)
            {
                account.UpdateBalance();
            }

            foreach (InvestmentAccount account in investmentAccounts)
            {
                Console.WriteLine(account);
            }

            foreach (InvestmentAccount account in investmentAccounts)
            {
                account.AddMoney(100f);
            }


            foreach (InvestmentAccount account in investmentAccounts)
            {
                Console.WriteLine(account);
            }

            //   investmentAccounts.Add
        }
    }
}
