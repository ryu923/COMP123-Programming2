using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronaut
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Astronaut> astronauts = new List<Astronaut>();
            astronauts.Add(Astronaut.CreateAstronaut("Yuri Gagarin", "Russian"));       // ASTRONAUT_COUNT = 0
            astronauts.Add(Astronaut.CreateAstronaut("Alan Shepard", "American"));      // ASTRONAUT_COUNT = 1
            astronauts.Add(Astronaut.CreateAstronaut("Virgil Grissom", "American"));    // ASTRONAUT_COUNT = 2
            astronauts.Add(Astronaut.CreateAstronaut("Gherman Titov", "Russian"));      // ASTRONAUT_COUNT = 3
            astronauts.Add(Astronaut.CreateAstronaut("John Glenn", "American"));        // ASTRONAUT_COUNT = 4
            astronauts.Add(Astronaut.CreateAstronaut("Scott Carpenter", "American"));   // ASTRONAUT_COUNT = 5 : This is null because the THRESHOLD is 5

            // Display astronauts upto THRESHOLD number(5)
            Console.WriteLine("[Display astronauts upto THRESHOLD number(5)]");
            foreach(Astronaut a in astronauts)
            {
                Console.WriteLine(a);
            }

            // Reset THRESHOLD(5) to 6 and Display astronauts upto THRESHOLD number(6)
            Console.WriteLine("[Reset THRESHOLD(5) to 6 and Display astronauts upto THRESHOLD number(6)]");
            Astronaut.SetThreshold(6);

            // Input an additional object again for adding into list of astronaut **
            astronauts.Add(Astronaut.CreateAstronaut("Scott Carpenter", "American"));   // ASTRONAUT_COUNT = 5

            foreach (Astronaut a in astronauts)
            {
                Console.WriteLine(a);
            }
        }
    }
}
