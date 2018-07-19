using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Rational
    {
        // PROPERTIES
        public int Denominator { get; private set; }
        public int Numerator { get; private set; }

        // CONSTRUCOTR
        public Rational(int numerator = 0, int denominator = 1)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        // METHODS
        public override string ToString()
        {
            return string.Format("{0} / {1}", Numerator, Denominator);
        }

        public void IncreaseBy(Rational other)
        {
            //Numerator += other.Numerator;
            //Denominator += other.Denominator;

            // Enhance to Rational Calculation Formula
            Numerator = (Numerator * other.Denominator) + (other.Numerator * Denominator);
            Denominator = Denominator * other.Denominator;
        }

        public void DecreaseBy(Rational other)
        {
            //Numerator -= other.Numerator;
            //Denominator -= other.Denominator;

            // Enhance to Rational Calculation Formula
            Numerator = (Numerator * other.Denominator) - (other.Numerator * Denominator);
            Denominator = Denominator * other.Denominator;
        }

        // Enhancement Using GCD(Greatest Common Divisor)
        public void Optimization()
        {
            Numerator = Numerator / GCD(Numerator, Denominator);
            Denominator = Denominator / GCD(Numerator, Denominator);

            Console.WriteLine(" - Optimization of Rational Number = {0} / {1}", Numerator, Denominator);
        }

        public static int GCD(int rationalNumberator, int rationalDenominator)
        {
            int remainder;

            while(rationalDenominator != 0)
            {
                remainder = rationalNumberator % rationalDenominator;

                rationalNumberator = rationalDenominator;
                rationalDenominator = remainder;
            }

            return rationalNumberator;
        }
    }
}
