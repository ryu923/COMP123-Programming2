using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide16_19
{
    // Slide 17
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

                // Add "empSal = 0"
                empSal = 0;
            }
        }
    }
}
