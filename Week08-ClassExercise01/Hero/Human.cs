using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public abstract class Human
    {
        // FIELDS
        private string _name;
        
        // PROPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                _name = value;
            }
        }

        // CONSTRUCTOR
        public Human(string name)
        {
            this.Name = name;
        }

        // METHODS
        public abstract void DisplaySkill();
        public abstract void Trains();
    }
}
