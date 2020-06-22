using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nazwa: Bank";
            string author = "Autor: Marek Zajac";
            
            Account savingsAccount = new SavingsAccount("940000000001", 0.0M, "Marek", "Zajac", 92010133333);
            
                       
            Account savingsAccount2 = new SavingsAccount("940000000002", 0.0M, "Jacek", "Placek", 91010166666);
                        

            Account billingAccount = new BillingAccount("940000000011", 0.0m, savingsAccount.FirstName, savingsAccount.LastName, savingsAccount.Pesel);
            

            Printer printer = new Printer();
            printer.Print(savingsAccount);
            printer.Print(savingsAccount2);
            printer.Print(billingAccount);
            string fullName = savingsAccount.GetFullName();
            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);
            string balance = savingsAccount.GetBalance();
            Console.WriteLine("stan konta: {0}", balance);
        }
    }
}
