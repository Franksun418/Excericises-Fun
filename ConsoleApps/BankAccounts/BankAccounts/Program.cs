using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new SavingsAccount(100m, 0.01m));
            accounts.Add(new CheckingAccount(500m));
            accounts.Add(new SavingsAccount(2000m, 0.02m));
            accounts.Add(new CheckingAccount(3000m));



            foreach (BankAccount account in accounts)
            {
                account.MakeDeposit(20m);
            }

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine();

        }

        
    }
}
