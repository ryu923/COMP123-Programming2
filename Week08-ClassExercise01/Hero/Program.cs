using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero1", 20);
            superHero.AddPower("SuperHero's Power1", 50);
            superHero.AddPower("SuperHero's Power2", 40);
            superHero.AddPower("SuperHero's Power3", 40);
            superHero.AddPower("SuperHero's Power4", 30);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma + "\n");

            SuperVillian superVillian = new SuperVillian("SuperVillian1", 20);
            superVillian.AddPower("SuperVillian's Power1", 50);
            superVillian.AddPower("SuperVillian's Power2", 30);
            superVillian.AddPower("SuperVillian's Power3", 30);
            superVillian.AddPower("SuperVillian's Power4", 20);
            Console.WriteLine(superVillian.ToString());
            Console.WriteLine("Malice: " + superVillian.Malice + "\n");

            Console.WriteLine("Compare Power between Super Hero and Super Villian");
            if (superHero.GetPower("SuperHero's Power1") > superVillian.GetPower("SuperVillian's Power2"))
            {
                Console.WriteLine(" - SuperHero's Power1 is more powerful than SuperVillian's Power2");
            }
            else
            {
                Console.WriteLine(" - SuperHero's Power1 is not more powerful than SuperVillian's Power2");
            }
        }
    }
}
