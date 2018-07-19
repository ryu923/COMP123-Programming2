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
            Console.WriteLine("[Create and Display the First object]");
            // Create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", "Gold", 2012, true);

            Console.WriteLine("\n-----------------------------------------------\n");

            // Display the object
            Console.WriteLine(m1);

            Console.WriteLine("\n-----------------------------------------------\n");

            // Print only the name of the medal holder
            Console.WriteLine("\n[Print only name of the object]");
            Console.WriteLine(m1.Name);

            Console.WriteLine("\n-----------------------------------------------\n");

            // Assign(Modify) the first object and Display
            Console.WriteLine("\n[Assign(Modify) the first object and Display]");
            m1 = new Medal("Michael Phelps", "Swimming", "Gold", 2012, false);
            Console.WriteLine(m1);

            Console.WriteLine("\n-----------------------------------------------\n");

            Console.WriteLine("[Create a list of medalist objects]");
            // Create a list to store the medal objects
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

            Console.WriteLine("\n===================================================\n");

            #region Question 1
            // Prints a numbered list of all athletes 16 medals
            Console.WriteLine("[Q1. Prints a numbered list of all athletes 16 medals]");

            int iQ1 = 1;

            foreach (Medal m in medals)
            {
                Console.WriteLine("{0}. " + m, iQ1);

                iQ1++;
            }
            #endregion

            Console.WriteLine("\n-----------------------------------------------\n");

            #region Question 2
            // Prints a numbered list of 16 athlete's enames
            Console.WriteLine("[Q2. Prints a numbered list of 16 athlete's enames]");
            int iQ2 = 1;

            foreach (Medal m in medals)
            {
                Console.WriteLine("{0}. " + m.Name, iQ2);

                iQ2++;
            }
            #endregion

            Console.WriteLine("\n-----------------------------------------------\n");

            #region Question 3
            // Prints a numbered list of 9 athletes who got gold medals
            Console.WriteLine("[Q3. Prints a numbered list of 9 athletes who got gold medals]");

            int iQ3 = 1;

            foreach (Medal m in medals)
            {
                if(m.Color == "Gold")
                {
                    Console.WriteLine("{0}. " + m.Name + " - " + m.Color, iQ3);

                    iQ3++;
                }    
            }
            #endregion

            Console.WriteLine("\n-----------------------------------------------\n");

            #region Question 4
            // Prints a numbered list of 9 athletes with medals in 2012
            Console.WriteLine("[Q4. Prints a numbered list of 9 medals in 2012]");
            int iQ4 = 1;

            foreach (Medal m in medals)
            {
                if (m.Year == 2012)
                {
                    Console.WriteLine("{0}. " + m.Year + " - " + m.Name + " - " + m.Color, iQ4);

                    iQ4++;
                }
            }
            #endregion

            Console.WriteLine("\n-----------------------------------------------\n");

            #region Question 5

            // Prints a numbered athletes list of 3 world record medals
            Console.WriteLine("[Q5. Prints a numbered athletes list of 3 world record medals]");
            int iQ5 = 1;

            foreach (Medal m in medals)
            {
                if (m.IsRecord == true)
                {
                    Console.WriteLine("{0}. " + m.Name + " - {1}", iQ5, (m.IsRecord)? "World Record" : "");

                    iQ5++;
                }
            }
            #endregion
        }
    }
}
