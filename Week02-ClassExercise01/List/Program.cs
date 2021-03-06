﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration and initialization of a list
            List<int> numbers = new List<int>() { 1, 2, 4, 5 };
            List<string> pms = new List<string>() { "Harper", "Martin", "Chretien", "Campbell" };
            // List<Rectangle> rectangles = new List<Rectangle>();

            // Adding an item to a list
            numbers.Add(3);
            pms.Add("Mulroney");

            // Inserting an item to a list
            pms.Insert(2, "William Lyon Mackenzie King");

            // Removing an item from a list
            pms.Remove("Mulroney");
            pms.RemoveAt(3);

            // Removing all items from a list
            // numbers.Clear();

            // Checking for the presence of an item in a list
            pms.Contains("Narendra Pershad");
            Console.WriteLine(pms.Contains("Narendra Pershad")); // Output is Boolean (True or False)

            // The number of items in a list
            numbers.Count();
            Console.WriteLine(numbers.Count()); // Output is integer

            Console.WriteLine("-----------------------");

            // Traversing a list
            Console.WriteLine("[List of numbers : Using For Loops]");
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n");

            // Or

            Console.WriteLine("[List of pms : Using Foreach]");
            foreach(int x in numbers)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
