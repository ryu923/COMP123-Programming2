using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medal
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", "Gold", 2012, true);
            //print the object
            Console.WriteLine(m1);
            //print only the name of the medal holder
            Console.WriteLine(m1.Name);

            //assign a new object to m1
            m1 = new Medal("Michael Phelps", "Swimming", "Gold", 2012, false);
            //print the updated m1
            Console.WriteLine(m1);

            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>();
            medals.Add(new Medal("Horace Gwynne", "Boxing", "Gold", 2012, true));
            medals.Add(new Medal("Michael Phelps", "Swimming", "Gold", 2012, false));
            medals.Add(new Medal("Ryan Cochrane", "Swimming", "Silver", 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", "Silver", 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", "Gold", 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", "Bronze", 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", "Gold", 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", "Gold", 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", "Bronze", 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", "Bronze", 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", "Gold", 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", "Bronze", 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", "Bronze", 2012, false));

            // [for] and [foreach] can be used in all below question (Just Chosen one)
            Console.WriteLine("\n----- Q1. Prints a numbered list of all athletes 16 medals -----");
            for(int i = 0; i < medals.Count; i++)
            {
                Console.WriteLine(medals[i]);
            }

            // [for] and [foreach] can be used in all below question (Just Chosen one)
            Console.WriteLine("\n----- Q2. Prints a numbered list of 16 athlete's names -----");
            foreach(Medal x in medals)
            {
                Console.WriteLine(x.Name);
            }

            // [for] and [foreach] can be used in all below question (Just Chosen one)
            Console.WriteLine("\n----- Q3. Prints a numbered list of 9 athletes who got gold medals -----");
            for(int i = 0; i < medals.Count; i++)
            {
                if(medals[i].Color == "Gold")
                {
                    Console.WriteLine(medals[i]);
                }
            }

            // [for] and [foreach] can be used in all below question (Just Chosen one)
            Console.WriteLine("\n----- Q4. Prints a numbered list of 9 athletes with medals in 2012 -----");
            foreach(Medal x in medals)
            {
                if(x.Year == 2012)
                {
                    Console.WriteLine(x);
                }
            }

            // [for] and [foreach] can be used in all below question (Just Chosen one)
            Console.WriteLine("\n----- Q5. Prints a numbered athletes list of 3 world record medals -----");
            for(int i = 0; i < medals.Count; i++)
            {
                if(medals[i].IsRecord == true)
                {
                    Console.WriteLine(medals[i]);
                }
            }
        }
    }
}
