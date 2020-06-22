using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class SavingsAccount : Account
    {
        public SavingsAccount()
        {

        }
        public SavingsAccount(string accountnumber, decimal balance, string firstname, string lastname, long pesel)
            : base(accountnumber, balance, firstname, lastname, pesel)
        {
        }

        public override string TypeName()
        {
            return "OSZCZĘDNOŚCIOWE";
        }
    }
}
