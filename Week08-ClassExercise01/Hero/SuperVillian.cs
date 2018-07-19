using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public class SuperVillian : SuperHuman, IHasMalice
    {
        // FIELDS
        private int _malice;

        // PROPERTIES
        public int Malice
        {
            get
            {
                return _malice;
            }
            set
            {
                this._malice = value;
            }
        }

        // CONSTRUCTORS
        public SuperVillian(string name, int malice) : base(name)
        {
            this.Malice = malice;
        }
    }
}
