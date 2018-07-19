using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add namespaces for JASON Serialization
using System.IO;
using System.Web.Script.Serialization;

namespace Invoice
{
    // 2. Invoice class: 40 Marks
    class Invoice
    {
        // FIELDS
        private List<Item> items = new List<Item>() { }; // 3 Marks

        // PROPERTIES
        public string Customer { get; private set; } // 2 Marks
        public string Mobile { get; private set; } // 2 Marks

        // CONSTRUCTOR
        public Invoice(string customer, string mobile) // 3 Marks
        {
            Customer = customer;
            Mobile = mobile;
        }

        // METHODS
        public void InsertItem(Item item) // 3 Marks
        {
            items.Add(item);
        }

        public void RemoveItem(string number) // 10 Marks
        {
            bool checkNumber = true;

            int i = 0;

            do
            {
                if(items[i].NUMBER.Contains(number))
                {
                    items.RemoveAt(i);

                    checkNumber = false;
                }

                i++;
            } while (i < items.Count);

            if (checkNumber)
                throw new Exception("Exception: Invoice #" + number + " was not found");
        }

        private string GetItems() // 8 Marks
        {
            string itemsList = "";

            foreach(Item x in items)
            {
                itemsList += x + "\n";
            }

            return itemsList;
        }

        public override string ToString() // 4 Marks
        {
            return string.Format(Customer + " tel. " + Mobile + "\nList of Items: \n" + GetItems());
        }

        public void SaveAsJson(string filename) // 6 Marks
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                JavaScriptSerializer jasonSerializer = new JavaScriptSerializer();

                writer.WriteLine(jasonSerializer.Serialize(items));

                writer.Close();
            }
        }
    }
}
