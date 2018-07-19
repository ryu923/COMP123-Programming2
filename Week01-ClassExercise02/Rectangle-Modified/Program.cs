using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Modified
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Q1. Create smallRectangle]");
            Rectangle smallRectangle = new Rectangle(5, 4);

            Console.WriteLine("\n[Q2. Describe smallRectangle]");
            Console.WriteLine(smallRectangle.ToString());

            Console.WriteLine("\n[Q3. Calculate area of smallRectangle and Display]");
            Console.WriteLine("Area: {0}", smallRectangle.GetArea());
        }
    }
}
