using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public enum TimeFormat
    {
        Mil,
        Hour12,
        Hour24
    }

    class Time
    {
        // FIELDS
        private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;

        // PROPERTIES
        public int Hour { get; private set; }
        public int Minute { get; private set; }

        // CONSTRUCTOR
        public Time(int hours, int minutes)
        {
            if(hours > 0 && hours < 24)
            {
                Hour = hours;
            }
            else
            {
                Hour = 0;
            }

            if(minutes > 0 && minutes < 60)
            {
                Minute = minutes;
            }
            else
            {
                Minute = 0;
            }
        }

        // METHODS
        public static void SetTimeFormat(TimeFormat time_format)
        {
            TIME_FORMAT = time_format;
        }

        // ToString() METHOD
        public override string ToString()
        {
            string result = "";

            switch(TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    result = string.Format("{0:D2}{1:D2}", Hour, Minute);
                    break;

                case TimeFormat.Hour24:
                    result = string.Format("{0:D2}:{1:D2}", Hour, Minute);
                    break;

                case TimeFormat.Hour12:
                    result = string.Format("{0}:{1:D2} {2}", Hour % 12, Minute, (Hour > 12)? "PM":"AM");
                    break;
            }

            return result;
        }
    }
}
