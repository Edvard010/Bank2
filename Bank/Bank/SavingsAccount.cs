﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class SavingsAccount : Account
    {
        public SavingsAccount()
        {

        }
        public SavingsAccount(int id, string firstname, string lastname, long pesel)
            : base(id, firstname, lastname, pesel)
        {
        }

        public override string TypeName()
        {
            return "OSZCZĘDNOŚCIOWE";           
        }
    }
}
