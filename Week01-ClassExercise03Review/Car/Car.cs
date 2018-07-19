using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        // FIELDS
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
            this.isDrivable = isDrivable;
            this.price = price;
        }

        // ToString() Method
        public override string ToString()
        {
            return string.Format("[{0}]\n" +
                                 " - Manufacturer: {1}\n" +
                                 " - Year: {2}\n" +
                                 " - Price: {3:C2}\n" +
                                 " - Dribable: {4}\n"
                                 , model, manufacturer, year, price, isDrivable);
        }
    }
}
