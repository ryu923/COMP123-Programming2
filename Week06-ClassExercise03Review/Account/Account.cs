using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        // FIELDS
        private static int CURRENT_ACCOUNT_NUMBER; // This should be static for [static Account()] CONSTRUCTOR
        public readonly string Number;
        private const int TRANSIT_NUMBER = 314;

        // PROPERTIES
        public double Balance { get; private set; }
        public List<string> Names { get; private set; }

        // CONSTRUCTOR
        static Account()
        {
            CURRENT_ACCOUNT_NUMBER = 10000;
        }
        private Account(string number, string name, double balance)
        {
            Number = number;
            Names = new List<string>();
            Balance = balance;
        }

        public void AddName(string name)
        {
            Names.Add(name);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1:C2}", Number, Balance);
        }

        public static Account CreateAccount(string name, double balance = 0)
        {
            string accountNumber = "AC-" + TRANSIT_NUMBER + "-" + CURRENT_ACCOUNT_NUMBER;

            CURRENT_ACCOUNT_NUMBER++;

            Account account = new Account(accountNumber, name, balance);

            return account;
        }
    }
}
