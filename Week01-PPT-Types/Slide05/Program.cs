using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reference Type
            ReferenceType Ra = new ReferenceType();
            ReferenceType Rb = Ra; // Ra copy to the reference is assigned to Rb

            Ra.age = 10;

            Console.WriteLine("[Reference Type]");
            Console.WriteLine(Ra.age + " <-> " + Rb.age);
            //outputs
            //10 <-> 10
            #endregion

            #region Value Type
            ValueType Va = new ValueType();
            ValueType Vb = Va; // Va copy of Va is assigned to Vb

            Va.age = 10;

            Console.WriteLine("\n[Value Type]");
            Console.WriteLine(Va.age + " <-> " + Vb.age);
            //outputs 
            //10 <-> 0
            #endregion
        }
    }
}
