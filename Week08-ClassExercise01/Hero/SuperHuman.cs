using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public class SuperHuman : Human
    {
        // FIELDS
        private List<Power> _powers;

        // PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers;
            }
        }

        // CONSTRUCTORS
        public SuperHuman(string name) : base(name)
        {
            this._initialize();
        }


        // METHODS
        private void _initialize()
        {
            this._powers = new List<Power>();
        }

        private int _getPowerIndex(string name)
        {
            int index = 0;

            foreach(Power power in this.Powers)
            {
                if(name.Equals(power.Name))
                {
                    break;
                }

                index++;

                if(this.Powers.Count == index)
                {
                    index = -1; // This means that we did not find the Power in the list
                }
            }

            return index;
        }

        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        public void DisplayPowers()
        {
            foreach(Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " + power.Rank);
            }
        }

        public override string ToString()
        {
            string outputString = "";
            outputString += "==================================\n";
            outputString += "SuperHuman Name: " + this.Name + "\n";
            outputString += "==================================\n";

            foreach(Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";
            }

            outputString += "==================================\n";

            return outputString;
        }

        public override void DisplaySkill()
        {
            Console.WriteLine("Not Implemented!");
        }

        public override void Trains()
        {
            Console.WriteLine("To Be implemented in Subclass");
        }

        public Power GetPower(string name)
        {
            int index = this._getPowerIndex(name);

            if(index != -1)
            {
                return this.Powers[index];
            }

            return new Power("Power Not Found", 0);
        }
    }
}
