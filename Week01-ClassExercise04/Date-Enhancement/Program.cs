using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Enhancement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Date Object: Original Date
            Console.WriteLine("[1 and 2. Create and Display Date Object: Original Date]");
            Date date = new Date(2018, 01, 01);
            Console.WriteLine(date.ToString());

            // 3-A. Called the Add() Method: Add 31days from #1 Date
            Console.WriteLine("\n[3-A. Called the Add() Method: Add 31 days from #1 Date]");
            date.Add(31);
            Console.WriteLine(date.ToString());

            // 3-B. Called the Add() Method: Add 5 Months and 10 Days from #3-A Date
            Console.WriteLine("\n[3-B. Called the Add() Method: Add 5 Months and 31 Days from #3-A Date]");
            date.Add(5, 31);
            Console.WriteLine(date.ToString());

            // 3-C. Called the Add() Method: Add 2018-08-01 Date from #3 Date
            Console.WriteLine("\n[3-C. Called the Add() Method: Add 2018-08-01 Date from #3 Date]");
            Date addedDate = new Date(2018, 08, 01);
            date.Add(addedDate);
            Console.WriteLine(date.ToString());
        }
    }
}
