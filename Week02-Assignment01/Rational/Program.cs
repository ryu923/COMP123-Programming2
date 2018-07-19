using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Q1. Create 4 Rational objects, print them
            Console.WriteLine("[Question 1 : Create 4 Rational objects, print them]");
            Rational rationalNumbers1 = new Rational(-1, 100);
            Rational rationalNumbers2 = new Rational(2, 100);
            Rational rationalNumbers3 = new Rational(3, 100);
            Rational rationalNumbers4 = new Rational(4, 100);

            Console.WriteLine("Rational Number 1: " + rationalNumbers1);
            Console.WriteLine("Rational Number 2: " + rationalNumbers2);
            Console.WriteLine("Rational Number 3: " + rationalNumbers3);
            Console.WriteLine("Rational Number 4: " + rationalNumbers4);
            #endregion

            Console.WriteLine("\n-------------------------------------------------\n");

            #region Question 2
            Console.WriteLine("[Question 2: Do some addition and subtraction and print again]");
            Console.WriteLine("1. Addition");
            rationalNumbers1.IncreaseBy(rationalNumbers2);
            Console.WriteLine("Rational Number 5 (Rational Number 1 + Rational Number 2): " + rationalNumbers1);

            rationalNumbers3.IncreaseBy(rationalNumbers4);
            Console.WriteLine("Rational Number 6 (Rational Number 3 + Rational Number 4): " + rationalNumbers3);

            Console.WriteLine("\n2. Subtraction");
            rationalNumbers3.DecreaseBy(rationalNumbers1);
            Console.WriteLine("Rational Number 7 (Rational Number 5 - Rational Number 6): " + rationalNumbers3);
            #endregion
        }
    }
}
