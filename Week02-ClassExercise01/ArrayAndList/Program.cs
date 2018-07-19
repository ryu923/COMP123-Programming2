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
            // Create [int[] arrayNumber] array - 3 ways
            int[] arrayNumber1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arrayNumber2 = { 1, 2, 3, 4, 5 };
            int[] arrayNumber3 = new int[5];
            arrayNumber3[0] = 1;
            arrayNumber3[1] = 2;
            arrayNumber3[2] = 3;
            arrayNumber3[3] = 4;
            arrayNumber3[4] = 5;

            // Resize the array before add item(s) to [int[] arrayNumber] array
            Array.Resize(ref arrayNumber1, 10);

            // Add 6, 7, 8, 9, and 10 to [int[] arrayNumber] array after resize the array
            arrayNumber1[5] = 6;
            arrayNumber1[6] = 7;
            arrayNumber1[7] = 8;
            arrayNumber1[8] = 9;
            arrayNumber1[9] = 10;

            // Add an item to specific position in [int[] arrayNumber] array
            // 1) Resize the array
            // 2) Re-declare items

            // Modify item on specific position in [int[] arrayNumber] array
            arrayNumber1[0] = 11;

            // Display [int[] arrayNumber] array
            Console.WriteLine("[int[] arrayNumber] array");
            foreach(int x in arrayNumber1)
            {
                Console.Write("{0} ", x);
            }

            // Checking the length of [int[] arrayNumber] array
            Console.WriteLine("\n=> The length of this array is {0}", arrayNumber1.Length);
            #endregion

            #region List
            // Create [List<int> listNumber] list
            List<int> listNumber = new List<int>() { 1, 2, 3, 4, 5 };

            // Add 6, 7, 8, 9, and 10 to the [List<int> listNumber] list
            listNumber.Add(6);
            listNumber.Add(7);
            listNumber.Add(8);
            listNumber.Add(9);
            listNumber.Add(10);

            // Add an item to specific position in [List<int> listNumber] list
            listNumber.Insert(0, 0);

            // Modify item on specific position in [List<int> listNumber] list
            for (int i = 0; i < listNumber.Count; i++)
            {
                if (listNumber.Contains(1))
                {
                    listNumber[i + 1] = 11;
                }
            }

            // Display [List<int> listNumber] list
            Console.WriteLine("\n\n[List<int> listNumber] list");
            foreach (int x in listNumber)
            {
                Console.Write("{0} ", x);
            }

            // Checking the count of [List<int> listNumber] list
            Console.WriteLine("\n=> The count of this list is {0}", listNumber.Count);
            #endregion
        }
    }
}
