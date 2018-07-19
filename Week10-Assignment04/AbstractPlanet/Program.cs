using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanet
{
    class Program
    {
        // 5 Marks
        static void Main(string[] args)
        {
            // 7-A. 1 Mark
            GiantPlanet GP1 = new GiantPlanet("A Planet", 100, 100, "Gas");

            // 7-B. 1 Mark
            Console.WriteLine(GP1.ToString());

            // 7-C. 1 Mark
            TerrestrialPlanet TP1 = new TerrestrialPlanet("B Planet", 200, 200, true);

            // 7-D. 1 Mark
            Console.WriteLine(TP1.ToString());

            // 7-E. 1 Mark
            WaitForAnyKey();
        }

        public static void WaitForAnyKey()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Please, press any key to close");
            Console.ReadKey();
        }
    }
}
// 8-A. Program Structure Check : 1 Mark