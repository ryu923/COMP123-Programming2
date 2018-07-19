using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide63_65
{
    // Slide 63
    static class Program
    {
        static void Main(string[] args)
        {
            int acctNum = 49;
            int revisedAcctnum = acctNum.AddcheckDigit();

            Console.WriteLine("Original account number was {0}", acctNum);
            Console.WriteLine("Revised account number is {0}", revisedAcctnum);
        }

        public static int AddcheckDigit(this int num)
        {
            int first = num / 10;
            int second = num % 10;
            int third = (first + second) % 10;
            int result = num * 10 + third;

            return result;
        }
    }
}
