using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide15
{
    class Dummy
    {
        public void NonStaticMethod()
        {
            Console.WriteLine("This is non-static method in Dummy class");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("This is static method in Dummy class");
        }
    }
}
