using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medal
{
    class Medal
    {
        //PROPERTIES
        public string Color { get; private set; }
        public bool IsRecord { get; private set; }
        public string Name { get; private set; }
        public string TheEvent { get; private set; }
        public int Year { get; private set; }

        // CONSTRUCTOR
        public Medal(string name, string theEvent, string color, int year, bool isRecord)
        {
            this.Name = name;
            this.TheEvent = theEvent;
            this.Color = color;
            this.Year = year;
            this.IsRecord = isRecord;
        }

        // METHODS
        public override string ToString()
        {
            return string.Format("{0} - {1}{2} {3}({4})", Year, TheEvent, IsRecord? "(R)" : "", Name, Color);
        }
    }
}
