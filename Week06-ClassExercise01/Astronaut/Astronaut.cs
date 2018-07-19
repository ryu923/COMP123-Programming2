using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronaut
{
    class Astronaut
    {
        // FIELDS
        // These variables should be [static] for applying to any places
        private static int ASTRONAUT_COUNT = 0;
        private static int THRESHOLD = 5;

        // PROPERTIES
        public string Name { get; private set; }
        public string Nationality { get; private set; }

        // CONSTRUCTOR
        private Astronaut(string name, string nationality)
        {
            this.Name = name;
            this.Nationality = nationality;

            ASTRONAUT_COUNT++;
        }

        // METHODS
        public static Astronaut CreateAstronaut(string name, string nationality) // This Method should be [static] for applying to other class.
        {
            if(ASTRONAUT_COUNT < THRESHOLD)
            {
                // Add an object to CONSTRUCTOR
                Astronaut astronaut = new Astronaut(name, nationality);

                return astronaut;
            }
            else
            {
                return null;
            }
        }

        public static void SetThreshold(int threshold)
        {
            THRESHOLD = threshold;
        } 

        // ToString() METHODS
        public override string ToString()
        {
            return string.Format("\n - Name        : " + Name +
                                 "\n - Nationality : " + Nationality);
        }
    }
}
