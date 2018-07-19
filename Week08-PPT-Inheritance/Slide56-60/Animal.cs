using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide56_60
{
    // Slide 57
    abstract class Animal : IWorkable
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract string Work();
    }
}
