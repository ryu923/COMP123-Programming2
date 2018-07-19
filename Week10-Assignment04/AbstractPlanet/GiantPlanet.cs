using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanet
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings // 8 Marks
    {
        // FIELDS(PRIVATE INSTANCE VARIABLES) : 2 Marks
        private string _type;

        // CONSTRUCTOR : 2 Marks
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }

        // METHODS
        public bool HasMoons() // 2 Marks : Check Again
        {
            if(MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings() // 2 Marks : Check Again
        {
            if(RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
// 8-C. Program Structure Check (FileName) : 1 Mark
// 8-F2. Program Structure Check (Private Variable) : 1 Mark