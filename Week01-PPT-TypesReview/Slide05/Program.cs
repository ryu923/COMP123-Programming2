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
            Console.WriteLine("[Reference Type]");
            RefType refTypeA = new RefType();
            RefType refTypeB = refTypeA;

            refTypeA.age = 10;

            Console.WriteLine(refTypeA.age + " <-> " + refTypeB.age);
            // Outputs: 10 <-> 10

            Console.WriteLine("\n[Value Type]");
            ValueType valueTypeA = new ValueType();
            ValueType valueTypeB = valueTypeA;

            valueTypeA.age = 10;

            Console.WriteLine(valueTypeA.age + " <-> " + valueTypeB.age);
            // Outputs: 10 <-> 0
            // [struct] type does not not support inheritance
        }
    }
}
