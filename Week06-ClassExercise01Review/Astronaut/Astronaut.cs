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
        private static int ASTRONAUT_COUNT = 0;
        private static int THRESHOLD = 5;

        // PROPERTIES
        public string Name { get; private set; }
        public string Nationality { get; private set; }

        // CONSTRUCTOR
        private Astronaut(string name, string nationality)
        {
            Name = name;
            Nationality = nationality;

            ASTRONAUT_COUNT++;
        }

        // METHODS
        public static Astronaut CreateAstronaut(string name, string nationality)
        {
            if(ASTRONAUT_COUNT < THRESHOLD)
            {
                Astronaut astronaut = new Astronaut(name, nationality);

                return astronaut;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return string.Format(" Name: " + Name + "\n" +
                                 " Nationality: " + Nationality + "\n");
        }

        public static void SetThreshold(int newThreshold)
        {
            THRESHOLD = newThreshold;
        }
    }
}
