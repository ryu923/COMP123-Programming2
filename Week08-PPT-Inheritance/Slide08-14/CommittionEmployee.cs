using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide08_14
{
    // Slide 12
    class CommittionEmployee : Employee
    {
        private double commissionRate;

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                commissionRate = value;
            }
        }
    }
}
