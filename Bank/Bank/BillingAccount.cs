using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BillingAccount : Account
    {
        public BillingAccount()
        {

        }
        public BillingAccount(string accountnumber, decimal balance, string firstname, string lastname, long pesel)
            : base(accountnumber, balance, firstname, lastname, pesel)
        {
        }

        public override string TypeName()
        {
            return "ROZLICZENIOWE";
        }
    }

}
