using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide26_28
{
    // Slide 26
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
                empSal = 0;
            }
        }

        new public string GetGreeting()
        {
            string greeting = base.GetGreeting();
            greeting += "\nI work on commission.";

            return greeting;
        }
    }
}
