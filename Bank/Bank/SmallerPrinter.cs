using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class SmallerPrinter : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane konta: {0}", account.AccountNumber);            
            Console.WriteLine("Imię właściciela: {0}", account.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", account.LastName);            
            Console.WriteLine();
        }
    }
}
