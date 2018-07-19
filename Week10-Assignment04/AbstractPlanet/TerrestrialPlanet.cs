using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanet
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable // 7 Marks
    {
        // FIELDS(PRIVATe INSTANCE VARIABLES) : 2 Marks
        private bool _oxygen;


        // CONSTRUCTOR : 2 Marks
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // METHODS
        public bool HasMoons() // 2 marks
        {
            if(MoonCount > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Habitable() // 2 Marks
        {
            if(_oxygen == true)
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
// 8-D. Program Structure Check (FileName) : 1 Mark
// 8-F3. Program Structure Check (Private Variable) : 1 Mark