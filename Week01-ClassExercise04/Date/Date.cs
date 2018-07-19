using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Date
    {
        // FIELDS (INSTANCE VARIABLES)
        private int year;
        private int month;
        private int day;

        // CONSTRUCTOR
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        // TOSTRING METHOD
        public override string ToString()
        {
            return string.Format("{0}-{1:D2}-{2:D2}", year, month, day);
        }

        // PUBLIC METHODS
        public void Add(int days)
        {
            this.day += days;
            
            Normalize();
        }

        public void Add(int months, int days)
        {
            this.month += months;
            this.day += days;

            Normalize();
        }

        public void Add(Date other)
        {
            this.year += year;
            this.month += month;
            this.day += day;

            Normalize();
        }

        // PRIVATE METHOD
        private void Normalize()
        {
            // Days
            if(day > 30)
            {
                day = day % 30;
                month = month + (month / 12);
            }


            // Months
            if(month > 12)
            {
                month = month % 12;
                year = year + (month / 12);
            }
        }
    }
}
