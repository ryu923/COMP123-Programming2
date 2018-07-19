using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLibrary
{
    public class Fraction
    {
        // PROPERTIES
        public int Top { get; private set; }
        public int Bottom { get; private set; }

        // CONSTRUCTOR
        public Fraction(int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }

        // Add another CONSTRUCTOR for Q1. One Argument Test
        public Fraction(int number)
        {
            Top = number;
            Bottom = 1;
        }

        // Add another CONSTRUCTOR for Q1. No Argument Test
        public Fraction()
        {
            Top = 0;
            Bottom = 1;
        }

        // OPERATORS
        public static Fraction operator +(Fraction left, Fraction right)
        {
            int top = (left.Top * right.Bottom) + (right.Top * left.Bottom);
            int bottom = left.Bottom * right.Bottom;

            return new Fraction(top, bottom);
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            int top = (left.Top * right.Bottom) - (right.Top * left.Bottom);
            int bottom = left.Bottom * right.Bottom;

            return new Fraction(top, bottom);
        }

        // METHODS
        public override string ToString()
        {
            return string.Format("{0}/{1}", Top, Bottom);
        }
    }
}
