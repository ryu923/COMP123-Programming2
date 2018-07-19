using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public class SuperHero : SuperHuman, IHasKarma
    {
        // FIELDS
        private int _karma;

        // PROPERTIES
        public int Karma
        {
            get
            {
                return _karma;
            }
            set
            {
                this._karma = value;
            }
        }

        // CONSTRUCTORS
        public SuperHero(string name, int karma) : base(name)
        {
            this.Karma = karma;
        }

        // METHODS
        public override void Trains()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}
