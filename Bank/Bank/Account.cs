using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public abstract class Account //klasa bazowa
    {
        public int Id { get; private set; }
        public string AccountNumber { get; private set; }
        public decimal Balance { get; set; } //nie może być "private set", bo metoda w savings account nie działa
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public long Pesel { get; private set; }
        public Account()
        {

        }
        public Account(int id, string firstname, string lastname, long pesel)
        {
            Id = id;
            AccountNumber = GenerateAccountNumber(id);
            Balance = 0.0m;
            FirstName = firstname;
            LastName = lastname;
            Pesel = pesel;
        }
        public abstract string TypeName();
        public string GetFullName()
        {
            string fullName = string.Format("{0} {1}", FirstName, LastName);

            return fullName;
        }
        public string GetBalance()
        {
            return string.Format("{0} zł", Balance);
        }
        private string GenerateAccountNumber(int id)
        {
            var accountNumber = string.Format("94{0:D10}", id);

            return accountNumber;
        }
        public void ChangeBalance(decimal value)
        {
            Balance += value;
        }
    }
}
