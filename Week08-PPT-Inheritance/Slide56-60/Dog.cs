﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide56_60
{
    // Slide 58
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public override string Work()
        {
            return "I Watch the house";
        }
    }
}
