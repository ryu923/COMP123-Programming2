using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    // 1. Item Class: 28 Marks
    class Item
    {
        // FIELDS
        private static int CURRENT_NUMBER = 100; // 3 Marks
        public readonly string NUMBER; // 3 Marks

        // PROPERTIES
        public bool IsBackOrdered { get; private set; } // 2 Marks
        public string Name { get; private set; } // 2 Marks
        public double Price { get; private set; } // 2 Marks
        public int Quantity { get; private set; } // 2 Marks

        // CONSTRUCTOR
        public Item(string name, double price, int quantity = 1, bool isBackOrdered = false) // 8 Marks
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            IsBackOrdered = isBackOrdered;

            NUMBER = Convert.ToString(CURRENT_NUMBER);
            CURRENT_NUMBER++;
        }

        // METHODS
        public override string ToString() // 7 Marks
        {
            return String.Format(" {0} - {1}pcs {2} @ {3:C} {4}", NUMBER, Quantity, Name, Price, IsBackOrdered? "(back ord)":"");
        }
    }
}
