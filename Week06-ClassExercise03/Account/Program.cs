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
            // Make a Account list
            List<Account> accounts = new List<Account>();

            // Create a Random number
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                accounts.Add(Account.CreateAccount("#" + i, random.Next(10, 100)));
            }

            Console.WriteLine("[All Account]");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine("\n[All Account with $1.11 Deposit]");
            foreach (Account account in accounts)
            {
                account.Deposit(1.11);

                Console.WriteLine(account);
            }

            Console.WriteLine("\n[All Account with $1.11 withdrawal]");
            foreach (Account account in accounts)
            {
                account.Withdraw(1.11);

                Console.WriteLine(account);
            }
        }
    }
}
