using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Time Setting: Basic Time Format (Hour12) -----");

            Time a = new Time(9, 35);
            Console.WriteLine(" - Time 1: " + a);
            Time b = new Time(18, 5);
            Console.WriteLine(" - Time 2: " + b);
            Time c = new Time(28, 500);
            Console.WriteLine(" - Time 3: " + c);

            Console.WriteLine();

            Console.WriteLine("----- Change Time Format: Mil -----");
            //change the format of the output
            Time.SetTimeFormat(TimeFormat.Mil);
            Console.WriteLine(" - Time 1 (Mil): " + a);
            Console.WriteLine(" - Time 2 (Mil): " + b);
            Console.WriteLine(" - Time 3 (Mil): " + c);

            Console.WriteLine();

            Console.WriteLine("----- Change Time Format: Hour24 -----");
            //change the format of the output
            Time.SetTimeFormat(TimeFormat.Hour24);
            Console.WriteLine(" - Time 1 (Hour24): " + a);
            Console.WriteLine(" - Time 2 (Hour24): " + b);
            Console.WriteLine(" - Time 3 (Hour24): " + c);

        }
    }
}
