using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                accounts.Add(Account.CreateAccount("#" + i, rand.Next(10, 100)));
            }

            Console.WriteLine("\n\nAll accounts");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            // Deposit $1.11
            foreach (Account account in accounts)
            {
                account.Deposit(1.11);
            }

            Console.WriteLine("\n\nAfter $1.11 deposit ");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            // Withdraw $0.05
            foreach (Account account in accounts)
            {
                account.Withdraw(0.05);
            }

            Console.WriteLine("\n\nAfter $0.05 withdrawal.");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

        }
    }
}
