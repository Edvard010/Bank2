using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nazwa: Bank";
            string author = "Autor: Marek Zajac";
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();
            SavingsAccount savingsAccount = new SavingsAccount();
            
            savingsAccount.AccountNumber = "940000000001";
            savingsAccount.Balance = 0.0M;
            savingsAccount.FirstName = "Marek";
            savingsAccount.LastName = "Zajac";
            savingsAccount.Pesel = 92010133333;

            Console.WriteLine("Dane konta:");
            Console.WriteLine("Numer konta: {0}", savingsAccount.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", savingsAccount.Balance);
            Console.WriteLine("Imię właściciela: {0}", savingsAccount.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", savingsAccount.LastName);
            Console.WriteLine("PESEL właściciela: {0}", savingsAccount.Pesel);

            SavingsAccount savingsAccount2 = new SavingsAccount();

            savingsAccount2.AccountNumber = "940000000002";
            savingsAccount2.Balance = 0.0M;
            savingsAccount2.FirstName = "Jacek";
            savingsAccount2.LastName = "Placek";
            savingsAccount2.Pesel = 91010166666;
            Console.WriteLine();
            Console.WriteLine("Dane konta nr 2:");
            Console.WriteLine("Numer konta: {0}", savingsAccount2.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", savingsAccount2.Balance);
            Console.WriteLine("Imię właściciela: {0}", savingsAccount2.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", savingsAccount2.LastName);
            Console.WriteLine("PESEL właściciela: {0}", savingsAccount2.Pesel);

            BillingAccount billingAccount = new BillingAccount();
            billingAccount.AccountNumber = "940000000011";
            billingAccount.Balance = 0.0m;
            billingAccount.FirstName = savingsAccount.FirstName;
            billingAccount.LastName = savingsAccount.LastName;
            billingAccount.Pesel = savingsAccount.Pesel;
            Console.WriteLine();
            Console.WriteLine("Dane konta rozliczeniowego:");
            Console.WriteLine("Numer konta: {0}", billingAccount.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", billingAccount.Balance);
            Console.WriteLine("Imię właściciela: {0}", billingAccount.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", billingAccount.LastName);
            Console.WriteLine("PESEL właściciela: {0}", billingAccount.Pesel);

        }
    }
}
