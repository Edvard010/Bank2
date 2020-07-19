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
            manager.CreateSavingsAccount("Marek", "Jarecki", 1234554321);

            IList<Account> accounts = (IList<Account>)manager.GetAllAccounts(); accounts = (IList<Account>)manager.GetAllAccounts();

            Printer printer = new Printer();

            foreach (Account account in accounts)
            {
                printer.Print(account);
            }
            Console.ReadKey();
            IEnumerable<string> users = manager.ListOfCustomers();
            foreach (string user in users)
            {
                Console.WriteLine(user);
            }
            Console.ReadKey();
            var konto = manager.GetAccount("940000000001");
            printer.Print(konto);
            Console.ReadKey();
            manager.AddMoney("940000000001", 100);
            printer.Print(konto);
        }
    }
}
