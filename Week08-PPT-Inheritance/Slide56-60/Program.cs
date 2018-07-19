using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 8. Interfaces
/// </summary>
namespace Slide56_60
{
    // Slide 59
    class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Employee("Bob");
            Dog spot = new Dog("Spot");
            Cat puff = new Cat("Puff");

            Console.WriteLine(bob.Name + " says " + bob.Work());
            Console.WriteLine(spot.Name + " says " + spot.Work());
            Console.WriteLine(puff.Name + " says " + puff.Work());
        }
    }
}
