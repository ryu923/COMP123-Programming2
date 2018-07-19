using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4-Cars
            Car car1 = new Car(2018, "Mercedez-Benz", "S-Class", 100000, true);
            Car car2 = new Car(2017, "BMW", "i8", 90000, true);
            Car car3 = new Car(2018, "Audi", "R8", 120000, false);
            Car car4 = new Car(2017, "Porsche", "911 GT3", 110000, false);

            // Display 4-Cars
            Console.WriteLine("[Car1 information] \n" + car1.ToString());
            Console.WriteLine("\n[Car2 information] \n" + car2.ToString());
            Console.WriteLine("\n[Car3 information] \n" + car3.ToString());
            Console.WriteLine("\n[Car4 information] \n" + car4.ToString());
        }
    }
}
