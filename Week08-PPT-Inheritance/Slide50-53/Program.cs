using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 7. Abstract Classes
/// </summary>
namespace Slide50_53
{
    // Slide 52
    class Program
    {
        static void Main(string[] args)
        {
            Dog spot = new Dog("Spot");
            Cat puff = new Cat("Puff");

            Console.WriteLine(spot.Name + " says " + spot.Speak());
            Console.WriteLine(puff.Name + " says " + puff.Speak());
        }
    }
}
