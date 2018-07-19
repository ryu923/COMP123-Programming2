using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide50_53
{
    // Slide 50
    abstract class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public abstract string Speak();
    }
}
