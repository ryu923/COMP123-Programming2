using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add namespace
using System.Linq;
using System.Collections.Generic;

namespace Slide55_58
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<string>();
            items.Add("aQua");
            items.Add("RusT");
            items.Add("yElLow");
            items.Add("rEd");

            Console.Write("items contains: ");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            var startWithR =
                from item in items
                let uppercaseString = item.ToUpper()
                where uppercaseString.StartsWith("R")
                orderby uppercaseString
                select uppercaseString;

            Console.Write("result of query startsWithR:");
            foreach(var item in startWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            items.Add("rUby");
            items.Add("SaFfRon");

            Console.Write("items contains:");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            Console.Write("result of query startsWithR:");
            foreach(var item in startWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();
        }
    }
}
