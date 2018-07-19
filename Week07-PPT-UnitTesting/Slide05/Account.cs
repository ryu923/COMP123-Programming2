using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide05
{
    class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public static string WithdrawAmountMoreThanLimitMessage { get; internal set; }

        public Account(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        //public void WithdrawAmountMoreThanLimitMessage()
        //{
        //    Console.WriteLine("Withdraw amount is more than limit!");
        //}
    }
}
