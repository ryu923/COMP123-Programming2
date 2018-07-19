using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    class Time
    {
        // FIELDS : No-Fields

        // PROPERTIES
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        // CONSTRUCTOR
        public Time(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        // ToString() Method
        public override string ToString()
        {
            return string.Format("{0}:{1:D2}:{2:D2}", Hours, Minutes, Seconds);
        }
    }
}
