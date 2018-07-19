using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide21_24
{
    class ScholarshipStudent : Student
    {
        public override int Credits
        {
            set
            {
                credits = value;
                tuition = 0;
            }
        }
    }
}
