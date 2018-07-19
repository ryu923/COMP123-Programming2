using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class GCD
    {
        public static void DisplayGCD(int number1, int number2)
        {
            int remainder;

            while (number2 != 0)
            {
                remainder = number1 % number2;

                number1 = number2;
                number2 = remainder;
            }

            Console.WriteLine("GCD = " + number1);
        }
    }
}
