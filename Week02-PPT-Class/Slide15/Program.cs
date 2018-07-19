using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide15
{
    class Program
    {
        static void Main(string[] args)
        {
            Dummy d1 = new Dummy();
            d1.NonStaticMethod();

            Dummy d2 = new Dummy();
            // d2.StaticMethod(); // This is an error because of [static] modifier in Dummy class
            Dummy.StaticMethod();
        }
    }
}
