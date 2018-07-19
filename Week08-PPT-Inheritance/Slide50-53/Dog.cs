using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide50_53
{
    // Slide 51
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public override string Speak()
        {
            return "woof";
        }
    }
}
