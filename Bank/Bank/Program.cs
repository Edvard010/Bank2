using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AccountsManager manager = new AccountsManager();

            manager.CreateBillingAccount("Marek", "Zajac", 92010133333);
            manager.CreateSavingsAccount("Jacek", "Placek", 91010166666);
            manager.CreateSavingsAccount("Zzzz", "Bbb", 0987654321);            
            manager.CreateSavingsAccount("Marek", "Aaaa", 1234554321);

            IList<Account> accounts = (IList<Account>)manager.GetAllAccounts(); accounts = (IList<Account>)manager.GetAllAccounts();

            Printer printer = new Printer();

            printer.Print(accounts[0]);
            printer.Print(accounts[2]);

            Console.ReadKey();
        }
    }
}
