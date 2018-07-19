using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    // 1. Customer class: 29 Marks
    class Customer
    {
        // FIELDS
        private static int LAST_ID = 501; // 3 Marks
        public string ID;

        // PROPERTIES
        public bool ForPickup { get; private set; } // 2 Marks
        public string Name { get; private set; } // 2 Marks
        public double Balance { get; private set; } // 2 Marks
        public string Tel { get; private set; } // 2 Marks

        // CONSTRUCTOR
        public Customer(string name, string tel, double balance = 0, bool forPickup = true) // 8 Marks
        {
            Name = name;
            Tel = tel;
            Balance = balance;
            ForPickup = forPickup;

            ID = Convert.ToString(LAST_ID);
            LAST_ID++;
        }

        // METHODS
        public override string ToString() // 8 Marks
        {
            return string.Format("{0} {1} {2} {3:C2} {4}", ID, Name, Tel, Balance, ForPickup? "(Pickup)" : "(Delivery)");
        }
    }
}
