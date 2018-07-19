using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide16_19
{
    // Slide 16
    class Employee
    {
        private int empNum;
        
        // Modify "private" to "protect" access specifier
        protected double empSal;

        public int EmpNum
        {
            get
            {
                return empNum;
            }
            set
            {
                empNum = value;
            }
        }

        public double EmpSal
        {
            get
            {
                return empSal;
            }
            set
            {
                empSal = value;
            }
        }

        public string GetGreeting()
        {
            string greeting = "Hello. I am employee #" + EmpNum;
            return greeting;
        }
    }
}
