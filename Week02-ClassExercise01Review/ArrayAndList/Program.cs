using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            Console.WriteLine("[Arrays]");

            // Declare Arrays
            int[] arrayNumber = new int[] { 0, 2, 3, 4, 5 }; // Output: 0, 2, 3, 4, 5
            string[] arrayString = new string[] { "B", "B", "D", "D", "E"}; // Output: B, B, C, D, E

            // Insert items in Arrays: Declare item position in array 
            arrayNumber[1] = 1;
            arrayNumber[2] = 2;
            arrayString[0] = "A";
            arrayString[2] = "C";

            // Delete specific items in Arrays *
            Array.Clear(arrayNumber, 3, 1);
            Array.Clear(arrayString, 3, 1);

            // Delete whole Arrays
            //Array.Clear(arrayNumber, 0, arrayNumber.Length);
            //Array.Clear(arrayString, 0, arrayNumber.Length);
            // arrayNumber = new int[0];
            // arrayString = new int[0];

            // Display Arrays
            for (int i = 0; i < arrayNumber.Length; i++) // Use [.Length]
            {
                Console.Write("{0} ", arrayNumber[i]); // Output: 0, 1, 2, 0, 5
            }

            Console.WriteLine();

            foreach(string x in arrayString)
            {
                Console.Write("{0} ", x); // Output: A, B, C,  , E
            }
            #endregion

            Console.WriteLine("\n");

            #region List
            Console.WriteLine("[Lists]");
            // Declare Lists
            List<int> listNumber = new List<int>() { 0, 2, 3, 4 }; // Output: 0, 2, 3, 4 
            List<string> listString = new List<string>() { "A", "C", "D"}; // Output: "A", "C", "D"

            // Insert items in Lists
            listNumber.Add(5); // Add item to the end of listNumber List
            listNumber.Insert(1, 1); // Insert item to the specific position of listNumber List

            listString.Add("E"); // Add item to the end of listString List
            listString.Insert(1, "B"); // Insert item to the specific position of listNumber List

            // Delete whole Arrays
            //listNumber.Clear();
            //listString.Clear();

            // Display Lists
            for (int i = 0; i < listNumber.Count; i++) // Use [.Count]
            {
                Console.Write("{0} ", i); // Output: 0, 1, 2, 3, 4, 5
            }

            Console.WriteLine();

            foreach(string x in listString)
            {
                Console.Write("{0} ", x); // Output: A, B, C, D, E
            }
            #endregion
        }
    }
}
