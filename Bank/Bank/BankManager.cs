using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BankManager
    {
        private AccountsManager _accountsManager;
        private IPrinter _printer;
        public BankManager()
        {
            _accountsManager = new AccountsManager();
            _printer = new Printer();
        }
        private void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - Lista kont klienta");
            Console.WriteLine("2 - Dodaj konto rozliczeniowe");
            Console.WriteLine("3 - Dodaj konto oszczędnościowe");
            Console.WriteLine("4 - Wpłać pieniądze na konto");
            Console.WriteLine("5 - Wypłać pieniądze z konta");
            Console.WriteLine("6 - Lista klientów");
            Console.WriteLine("7 - Wszystkie konta");
            Console.WriteLine("8 - Zakończ miesiąc");
            Console.WriteLine("0 - Zakończ");
        }
        private int SelectedAction()
        {
            Console.Write("Akcja: ");
            string action = Console.ReadLine();
            if (string.IsNullOrEmpty(action))
            {
                return -1;
            }
            return int.Parse(action);
        }
        public void Run()
        {
            int action;
            do
            {
                PrintMainMenu();
                action = SelectedAction();
            }
            while (action != 0);
        }
    }
}
