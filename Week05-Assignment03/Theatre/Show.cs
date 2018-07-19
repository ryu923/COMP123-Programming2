﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    class Show
    {
        // FIELDS : No-Fields

        // PROPERTIES
        public double Price { get; private set; }
        public MovieDay Day { get; private set; }
        public Movie Movie { get; private set; }
        public Time Time { get; private set; }

        // CONSTRUCTOR
        public Show(Movie movie, MovieDay day, double price, Time time)
        {
            this.Movie = movie;
            this.Day = day;
            this.Price = price;
            this.Time = time;
        }

        // ToString() METHOD
        public override string ToString()
        {
            return string.Format(Movie + 
                                "\n- Day   : " + Day +
                                "\n- Price : $" + Price +
                                "\n- Time  : " + Time);
            //return string.Format("{0} {1} {2} {3}", Movie, Day, Price, Time);
        }
    }
}
