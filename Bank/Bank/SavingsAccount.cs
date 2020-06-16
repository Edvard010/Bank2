using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class SavingsAccount
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;
        public SavingsAccount()
        {

        }
        public SavingsAccount(string accountnumber, decimal balance, string firstname, string lastname, long pesel)
        {
            accountnumber = AccountNumber;
            balance = Balance;
            firstname = FirstName;
            lastname = LastName;
            pesel = Pesel;

        }
    }
}
