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
            Console.WriteLine("Q1. Create four objects. You decide on the arguments.");
            Pet pet1 = new Pet("Puppy1", 1, "Cute Dog");
            Pet pet2 = new Pet("Puppy2", 2, "Lovely Dog");
            Pet pet3 = new Pet("Kitten1", 1, "Cute Cat");
            Pet pet4 = new Pet("Kitten2", 2, "Lovely Cat");

            Console.WriteLine("Q2. Use all the methods on the four objects.");
            Console.WriteLine(pet1.ToString());
            Console.WriteLine(pet2.ToString());
            Console.WriteLine(pet3.ToString());
            Console.WriteLine(pet4.ToString());

            Console.WriteLine("Q3. How will you modify your class to do this to be able to see the owner’s name? Do the necessary modification.");
            pet1.modifyOwner("Ryu");
            Console.WriteLine(pet1.ToString());
            pet2.modifyOwner("Candice");
            Console.WriteLine(pet2.ToString());
            pet3.modifyOwner("Ryu");
            Console.WriteLine(pet3.ToString());
            pet4.modifyOwner("Candice");
            Console.WriteLine(pet4.ToString());

            Console.WriteLine("Q4. Create a List to store all the above objects.");
            List<Pet> pets = new List<Pet>() { pet1, pet2, pet3, pet4 };

            Console.WriteLine("Q5.	Display all the items in the List");
            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine("{0}", pets[i]);
            }

            Console.WriteLine("---------- Or ----------");

            foreach (Pet x in pets)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Q6. Display only the pets belonging to a particular person");
            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Owner == "Ryu")
                {
                    Console.WriteLine("{0}", pets[i]);
                }
            }

            Console.WriteLine("---------- Or ----------");

            foreach(Pet x in pets)
            {
                if(x.Owner == "Candice")
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
