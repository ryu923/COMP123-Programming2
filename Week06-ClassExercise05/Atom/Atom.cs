using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom
{
    public class Atom
    {
        // FIELDS
        public string name;
        public string symbol;
        public int proton;
        public int neutron;
        public double weight;

        // CONSTRUCTORS
        public Atom()
        {

        }

        public Atom(string name, int proton, int neutron, double weight, string symbol)
        {
            this.name = name;
            this.proton = proton;
            this.neutron = neutron;
            this.weight = weight;
            this.symbol = symbol;
        }

        // METHODS
        public static Atom Parse(string line)
        {
            string[] atomArray = line.Split(' ');

            Atom atom = new Atom(atomArray[0], Convert.ToInt32(atomArray[1]), Convert.ToInt32(atomArray[2]), Convert.ToDouble(atomArray[3]), atomArray[4]);

            return atom;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", name, proton, neutron, weight, symbol);
        }
    }
}
