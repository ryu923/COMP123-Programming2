using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add namespace
using System.IO;

namespace Customer
{
    // 2. Store class: 38 Marks
    class Store
    {
        // FIELDS
        private List<Customer> customers = new List<Customer>() { }; // 3 Marks
        private string name; // 1 Marks
        private string tel; // 1 Marks

        // CONSTRUCTOR
        public Store(string customer, string mobile) // 3 Marks
        {
            name = customer;
            tel = mobile;
        }

        // METHODS
        public void InsertCustomer(Customer Customer) // 3 Marks
        {
            customers.Add(Customer);
        }

        public override string ToString() // 4 Marks
        {
            return string.Format(name + "tel. " + tel + "\nList of customers: \n" + GetCustomers());
        }

        public void RemoveCustomer(string number) // 10 Marks
        {
            bool checkNumber = true;

            int i = 0;

            while(i < customers.Count())
            {
                if(customers[i].ID.Contains(number))
                {
                    customers.RemoveAt(i);

                    checkNumber = false;
                }
                i++;
            }

            if (checkNumber)
                throw new Exception("Exception: Customer #" + number + " was not found");
        }

        public string GetCustomers() // 8 Marks
        {
            string customersList = "";

            foreach (Customer x in customers)
            {
                customersList += " " + x + "\n";
            }

            return customersList;
        }

        public void SaveAsText(string filename) // 5 Marks
        {
            TextWriter writer = new StreamWriter(filename);

            for(int i = 0; i < customers.Count; i++)
            {
                writer.WriteLine(customers[i].ToString());
            }

            writer.Close();
        }
    }
}
