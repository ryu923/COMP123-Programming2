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
            Console.WriteLine("[Q1. Create 4 Rational objects, print them]");
            Rational rationalNumber1 = new Rational(1, 2);
            Rational rationalNumber2 = new Rational(2, 3);
            Rational rationalNumber3 = new Rational(3, 4);
            Rational rationalNumber4 = new Rational(4, 5);

            Console.WriteLine(" - Rational Number1: " + rationalNumber1.ToString());
            Console.WriteLine(" - Rational Number2: " + rationalNumber2.ToString());
            Console.WriteLine(" - Rational Number3: " + rationalNumber3.ToString());
            Console.WriteLine(" - Rational Number4: " + rationalNumber4.ToString());

            Console.WriteLine("\n[Q2.Do some addition and subtraction and print again]");
            rationalNumber1.IncreaseBy(rationalNumber2);
            rationalNumber4.DecreaseBy(rationalNumber3);

            Console.WriteLine(" Rational Number1 + Rational Number2: " + rationalNumber1);
            Console.WriteLine(" Rational Number4 - Rational Number3: " + rationalNumber4);

            Console.WriteLine("\n-----Enhancement: Based on Rational Number Calculation Formula]-----");
            Console.WriteLine("[E1. Add new 4 Rational objects, print them]");
            Rational rationalNumber5 = new Rational(1, 2);
            Rational rationalNumber6 = new Rational(2, 3);
            Rational rationalNumber7 = new Rational(3, 4);
            Rational rationalNumber8 = new Rational(4, 5);

            Console.WriteLine(" - Rational Number5: " + rationalNumber5.ToString());
            Console.WriteLine(" - Rational Number6: " + rationalNumber6.ToString());
            Console.WriteLine(" - Rational Number7: " + rationalNumber7.ToString());
            Console.WriteLine(" - Rational Number8: " + rationalNumber8.ToString());

            Console.WriteLine("\n[E2. Do some addition and subtraction and print again by rational calculation formula]");
            rationalNumber5.IncreaseBy(rationalNumber6);
            Console.WriteLine(" Rational Number5 + Rational Number6: " + rationalNumber5);

            rationalNumber8.DecreaseBy(rationalNumber7);
            Console.WriteLine(" Rational Number8 - Rational Number7: " + rationalNumber8);

            Console.WriteLine("\n[E3. Rational Number Optimization]");
            Rational rationalNumber9 = new Rational(32, 12);
            Console.WriteLine(" - Rational Number9: " + rationalNumber9.ToString());
            rationalNumber9.Optimization();
        }
    }
}
