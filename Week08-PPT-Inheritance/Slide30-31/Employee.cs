﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide30_31
{
    // Addition to Slide 30
    class Employee
    {
        private int empNum;

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
