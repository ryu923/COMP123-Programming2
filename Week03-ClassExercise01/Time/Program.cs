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
            Console.WriteLine("[Time Setting to Time 1, 2, and 3]");
            Time a = new Time(9, 35);
            Console.WriteLine("- Time 1: " + a);

            Time b = new Time(18, 5);
            Console.WriteLine("- Time 2: " + b);

            Time c = new Time(28, 500);
            Console.WriteLine("- Time 3: " + c);

            Console.WriteLine("\n---------------------------------------\n");

            Console.WriteLine("[Time Format Setting]");
            Time.SetTimeFormat(TimeFormat.Mil);
            Console.WriteLine("- Time 1 Format Mil: " + a);
            Console.WriteLine("- Time 2 Format Mil: " + b);
            Console.WriteLine("- Time 3 Format Mil: " + c);

            Time.SetTimeFormat(TimeFormat.Hour12);
            Console.WriteLine("- Time 1 Format Hour12: " + a);
            Console.WriteLine("- Time 2 Format Hour12: " + b);
            Console.WriteLine("- Time 3 Format Hour12: " + c);

            Time.SetTimeFormat(TimeFormat.Hour24);
            Console.WriteLine("- Time 1 Format Hour24: " + a);
            Console.WriteLine("- Time 2 Format Hour24: " + b);
            Console.WriteLine("- Time 3 Format Hour24: " + c);
        }
    }
}
