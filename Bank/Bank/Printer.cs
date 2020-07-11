using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Printer : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Numer konta: {0}", account.AccountNumber);               
            Console.WriteLine("Saldo: {0}zł", account.Balance);
            Console.WriteLine("Imię właściciela: {0}", account.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", account.LastName);
            Console.WriteLine("PESEL właściciela: {0}", account.Pesel);
            var tekst = account.TypeName();
            Console.WriteLine(tekst);
            Console.WriteLine();
        }
        
    }
}
