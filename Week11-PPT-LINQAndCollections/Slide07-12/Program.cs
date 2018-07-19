using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Slide 07
using System.Linq;

namespace Slide07_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slide 07
            var values = new[] {2, 9, 5, 0, 3, 7, 1, 4, 8, 5};

            Console.Write("Original array:");
            foreach(var element in values)
            {
                Console.Write($" {element}");
            }

            // Slide 08
            var filtered = 
                from value in values
                where value > 4
                select value;

            Console.Write("\nArray values greater than 4:");
            foreach(var element in filtered)
            {
                Console.Write($" {element}");
            }

            // Slide 09
            var sorted =
                from value in values
                orderby value
                select value;

            Console.Write("\nOriginal array, sorted");
            foreach(var element in sorted)
            {
                Console.Write($" {element}");
            }

            // Slide 10
            var sortFilteredResult =
                from value in filtered
                orderby value descending
                select value;

            Console.Write("\nValues greater than 4, descending order (two queries):");
            foreach(var element in sortFilteredResult)
            {
                Console.Write($" {element}");
            }

            // Slide 11
            var sortAndFilter =
                from value in values
                where value > 4
                orderby value descending
                select value;

            Console.Write("\nValue greater than 4, descending order (one query)");
            foreach(var element in sortAndFilter)
            {
                Console.Write($" {element}");
            }

            Console.WriteLine();
        }
    }
}
