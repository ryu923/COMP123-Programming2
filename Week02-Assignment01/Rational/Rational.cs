using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Rational
    {
        // FIELDS (INSTANCE VARIABLES)

        // PROPERTIES
        public int Denominator { get; private set; }
        public int Numberator { get; private set; }

        // CONSTRUCTOR
        public Rational(int numberator = 0, int denominator = 1)
        {
            this.Numberator = numberator;
            this.Denominator = denominator;
        }

        // ToString() METHOD
        public override string ToString()
        {
            optimizationRationalNumber();

            return string.Format("{0}/{1}", Numberator, Denominator);
        }

        // PUBLIC METHODS
        public void IncreaseBy(Rational other)
        {
            Rational newAdditionalNumber = new Rational();
            newAdditionalNumber.Numberator = (this.Numberator * other.Denominator) + (other.Numberator * this.Denominator);
            newAdditionalNumber.Denominator = (this.Denominator * other.Denominator);

            this.Numberator = newAdditionalNumber.Numberator;
            this.Denominator = newAdditionalNumber.Denominator;
        }

        public void DecreaseBy(Rational other)
        {
            Rational newSubtractNumber = new Rational();
            newSubtractNumber.Numberator = (this.Numberator * other.Denominator) - (other.Numberator * this.Denominator);
            newSubtractNumber.Denominator = (this.Denominator * other.Denominator);

            this.Numberator = newSubtractNumber.Numberator;
            this.Denominator = newSubtractNumber.Denominator;
        }

        // Add this Method for optimizatino of rational numbers
        public void optimizationRationalNumber()
        {
            for(int i = 2; i <= this.Numberator; )
            {
                if((this.Numberator % i == 0) && (this.Denominator % i == 0))
                {
                    this.Numberator = this.Numberator / i;
                    this.Denominator = this.Denominator / i;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
