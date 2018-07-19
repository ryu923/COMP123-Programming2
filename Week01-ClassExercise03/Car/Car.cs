using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        // FIELDS(INSTANCE VARIABLES)
        private int year;
        private string manufacturer;
        private string model;
        private bool isDrivable;
        private double price;

        // CONSTRUCTOR
        public Car(int year, string manufacturer, string model, double price, bool isDrivable = true)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.isDrivable = isDrivable;
        }

        // TOSTRING
        public override string ToString()
        {
            return string.Format("- Year: " + year +
                                 "\n- Manufacturer: " + manufacturer + 
                                 "\n- Model: " + model +
                                 "\n- Price: $" + price + 
                                 "\n- Drivable: " + isDrivable);
        }

    }
}
