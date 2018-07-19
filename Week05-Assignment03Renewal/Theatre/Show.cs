using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    class Show
    {
        // Properties
        public double Price { get; private set; }
        public MovieDay Day { get; private set; }
        public Movie Movie { get; private set; }
        public Time Time { get; private set; }

        // Constructor
        public Show(Movie movie, MovieDay day, double price, Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }

        // METHODS
        public override string ToString()
        {
            return string.Format(Movie + 
                                 "\n - Day   : " + Day +
                                 "\n - Time  : " + Time +
                                 "\n - Price : $" + Price);
        }
    }
}
