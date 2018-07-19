using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration and initialization of a list
            List<int> numbers = new List<int>();
            List<string> pms = new List<string>() { "Harper", "Martin", "Chretien", "Campbell" };
            // List<Rectangle> rectangles = new List<Rectangle>();

            // Adding an item to a list
            numbers.Add(3);
            pms.Add("Mulroney");

            // Inserting an item to a list
            pms.Insert(2, "William Lyon Mackenzie King");

            // Removing an item from a list
            pms.Remove("Mulroney");
            numbers.RemoveAt(3);

            // Removing all items from a list
            numbers.Clear();

            // Checking for the presence of an item in a list
            pms.Contains("Narendra Pershad");

            // The number of items in a list
            numbers.Count();

            // Traversing a list
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // foreach is read-only
            foreach(int x in numbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}
