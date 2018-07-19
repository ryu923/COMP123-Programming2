using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        // FIELDS : No-Fields

        // PROPERTIES
        public int Real { get; private set; }
        public int Imaginary { get; private set; }
        public double Modulus
        {
            get
            {
                return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
            }
        }
        public double Argument
        {
            get
            {
                return 1 / Math.Tan(Real / Imaginary);
            }
        }

        // CONSTRUCTOR
        public Complex(int real, int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        // ToString() METHOD
        public override string ToString()
        {
            return string.Format("({0}, {1})", Real, Imaginary);
        }

        // OPERATORS
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;

            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;

            return new Complex(real, imaginary);
        }

        public static Complex operator *(Complex lhs, Complex rhs)
        {
            int real = ((lhs.Real * rhs.Real) - (lhs.Imaginary * rhs.Imaginary));
            int imaginary = ((lhs.Real * rhs.Imaginary) + (lhs.Imaginary * rhs.Real));
            return new Complex(real, imaginary);
        }

        public static Complex operator /(Complex lhs, Complex rhs)
        {
            int real = lhs.Real / rhs.Real;
            int imaginary = lhs.Imaginary / rhs.Imaginary;

            return new Complex(real, imaginary);
        }

        // operator == and != should be [Boolean] struct and come together
        public static Boolean operator ==(Complex lhs, Complex rhs)
        {
            return (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary);
        }

        public static Boolean operator !=(Complex lhs, Complex rhs)
        {
            return (lhs.Real != rhs.Real && lhs.Imaginary != rhs.Imaginary);
        }
    }
}
