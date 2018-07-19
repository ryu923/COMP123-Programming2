using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide56_60
{
    class Employee : IWorkable
    {
        public Employee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Work()
        {
            return "I do my job";
        }
    }
}
