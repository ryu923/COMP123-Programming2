using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
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
            Real = real;
            Imaginary = imaginary;
        }

        // METHODS
        public override string ToString()
        {
            return string.Format("({0}:{1})", Real, Imaginary);
        }

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

        public static Boolean operator ==(Complex lhs, Complex rhs)
        {
            return (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary);
        }
        public static Boolean operator !=(Complex lhs, Complex rhs)
        {
            return (lhs.Real != rhs.Real && lhs.Imaginary != rhs.Imaginary);
        }

        public static Complex operator *(Complex lhs, Complex rhs)
        {
            int real = lhs.Real * rhs.Real;
            int imaginary = lhs.Imaginary * rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            int real = lhs.Real / rhs.Real;
            int imaginary = lhs.Imaginary / rhs.Imaginary;
            return new Complex(real, imaginary);
        }
    }
}
