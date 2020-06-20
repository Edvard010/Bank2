using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public abstract class Account //klasa bazowa
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;
        public Account()
        {

        }
        public Account(string accountnumber, decimal balance, string firstname, string lastname, long pesel)
        {
            AccountNumber = accountnumber;
            Balance = balance;
            FirstName = firstname;
            LastName = lastname;
            Pesel = pesel;
        }
        public string GetFullName()
        {
            string fullName = string.Format("{0} {1}", FirstName, LastName);

            return fullName;
        }
        public string GetBalance()
        {
            return string.Format("{0} zł", Balance);

        }
    }
}
