using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide33_34
{
    // Add to Slide 33
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
