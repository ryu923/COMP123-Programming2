using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1. Create four objects. You decide on the arguments
            Console.WriteLine("[Question 1]");
            Pet pet1 = new Pet("Puppy1", 1, "Cute Dog");
            Pet pet2 = new Pet("Puppy2", 2, "Lovely Dog");
            Pet pet3 = new Pet("Kitten1", 1, "Cute Cat");
            Pet pet4 = new Pet("Kitten2", 2, "Lovely Cat");

            Console.WriteLine("\n========================================\n");

            // Q2. Use all the methods on the four objects. (?)
            Console.WriteLine("[Question 2]");
            Console.WriteLine(pet1); // [Console.WriteLine();] connects to [ToString()] Method in Pet class
            Console.WriteLine(pet2);
            Console.WriteLine(pet3);
            Console.WriteLine(pet4);

            Console.WriteLine("\n========================================\n");

            // 3. How will you modify your class to do this to be able to see the owner’s name? Do the necessary modification.
            Console.WriteLine("[Question 3]");
            pet1.modifyOwner("David");
            Console.WriteLine(pet1);

            pet3.modifyOwner("Candice");
            Console.WriteLine(pet3);

            Console.WriteLine("\n========================================\n");

            // 4. Create a List to store all the above objects.
            Console.WriteLine("[Question 4]");
            List<Pet> pets = new List<Pet>() { pet1, pet2, pet3, pet4 };

            Console.WriteLine("\n========================================\n");

            // 5. Display all the items in the List
            Console.WriteLine("[Question 5]");
            foreach (Pet p in pets)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n========================================\n");

            // 6. Display only the pets belonging to a particular person
            Console.WriteLine("[Question 6]");
            foreach(Pet p in pets)
            {
                if(p.choiceOwner() == "David" || p.choiceOwner() == "Candice")
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
