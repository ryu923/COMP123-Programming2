using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Enhancement
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
            Normalize();

            #region Enhancement 1 : Change number of month to letter of month format
            string monthletter = Convert.ToString(month);

            switch (monthletter)
            {
                case "1":
                    monthletter = "January";
                    break;
                case "2":
                    monthletter = "February";
                    break;
                case "3":
                    monthletter = "March";
                    break;
                case "4":
                    monthletter = "April";
                    break;
                case "5":
                    monthletter = "May";
                    break;
                case "6":
                    monthletter = "June";
                    break;
                case "7":
                    monthletter = "July";
                    break;
                case "8":
                    monthletter = "August";
                    break;
                case "9":
                    monthletter = "September";
                    break;
                case "10":
                    monthletter = "October";
                    break;
                case "11":
                    monthletter = "November";
                    break;
                case "12":
                    monthletter = "December";
                    break;
            }
            #endregion

            // return string.Format("{0}-{1:D2}-{2:D2}", year, month, day);
            return string.Format("{0}-{1}-{2:D2}", year, monthletter, day);
        }

        // PUBLIC METHODS
        public void Add(int days)
        {
            this.day += days;
        }

        public void Add(int months, int days)
        {
            this.month += months;
            this.day += days;
        }

        public void Add(Date other)
        {
            this.year += year;
            this.month += month;
            this.day += day;
        }

        // PRIVATE METHOD
        private void Normalize()
        {
            #region Enhancement 2 : Handle the different month length properly 
            if (month % 12 == 1 || month % 12 == 3 || month % 12 == 5 || month % 12 == 7 || month % 12 == 8 || month % 12 == 10 || month % 12 == 0)
            {
                if(day > 31)
                {
                    month = month + (day / 31);
                    day = day % 31;
                }

                if (month > 12)
                {
                    year = year + (month / 12);
                    month = month % 12;
                }
            }

            else if(month % 12 == 4 || month % 12 == 6 || month % 12 == 9 || month % 12 == 11)
            {
                if(day > 30)
                {
                    month = month + (day / 30);
                    day = day % 30;
                }

                if(month > 12)
                {
                    year = year + (month / 12);
                    month = month % 12;
                }
            }

            else if(month % 12 == 2)
            {
                // Leap Year
                if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    if(day > 29)
                    {
                        month = month + (day / 29);
                        day = day % 29; 
                    }

                    if(month > 12)
                    {
                        year = year + (month / 12);
                        month = month % 12;
                    }
                }
                else
                {
                    if (day > 28)
                    {
                        month = month + (day / 28);
                        day = day % 28;
                    }

                    if (month > 12)
                    {
                        year = year + (month / 12);
                        month = month % 12;
                    }
                }
            }
            #endregion
        }
    }
}
