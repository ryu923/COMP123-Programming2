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
            Car car1 = new Car(2018, "Mercedez-Benz", "SLK-900", 900000, true);
            Console.WriteLine(car1.ToString());

            Car car2 = new Car(2018, "BMW", "i9", 900000, true);
            Console.WriteLine(car2.ToString());

            Car car3 = new Car(2018, "Audi", "R9", 900000, false);
            Console.WriteLine(car3.ToString());

            Car car4 = new Car(2018, "L​amborghini", "L9", 900000, false);
            Console.WriteLine(car4.ToString());
        }
    }
}
