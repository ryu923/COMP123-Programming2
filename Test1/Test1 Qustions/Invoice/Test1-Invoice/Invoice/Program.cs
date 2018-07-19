using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        // 3. Test Harness
        static void Main(string[] args)
        {
            //test the item class
            Console.WriteLine("\n*****Testing the Item Class");
            Console.WriteLine(new Item("Mouse", 5.21));
            Console.WriteLine(new Item("Keybaord", 14.99, 4));
            Console.WriteLine(new Item("Monitor", 124.98, 2, true));

            //test the invoice class
            Console.WriteLine("\n*****Testing the Invoice Class");
            Console.WriteLine(new Invoice("Jean Chretien", "647-124-5678"));

            //testing AddItem method of the invoice class
            Console.WriteLine("\n*****Testing the AddItem() for first invoice");
            Invoice inv0 = new Invoice("Kim Campbell", "647-123-4567");
            inv0.InsertItem(new Item("Crucial SSD", 199.97, 5));
            inv0.InsertItem(new Item("Samsung Led Monitor", 7, 4, true));
            inv0.InsertItem(new Item("GeForce GTX", 28, 6, true));
            inv0.InsertItem(new Item("Sapphire Radeon", 14, 12, true));
            Console.WriteLine(inv0);

            Console.WriteLine("\n*****Testing the AddItem() for second invoice");
            Invoice inv1 = new Invoice("Brian Mulroney", "416-289-5000");
            inv1.InsertItem(new Item("Netgear Router", 7, 1, true));
            inv1.InsertItem(new Item("Asus Router", 21));
            inv1.InsertItem(new Item("Samsung Galaxy", 56, 2, true));
            inv1.InsertItem(new Item("Asus MeMO Pad", 42, 3, true));
            inv1.InsertItem(new Item("Lenovo Tablet", 599.99, 1, false));
            inv1.InsertItem(new Item("Ematic Tablet", 21, 4));
            inv1.InsertItem(new Item("HP Elitebook", 1896.89));
            inv1.InsertItem(new Item("Macbook Pro", 2300));
            Console.WriteLine(inv1);

            Console.WriteLine("Saving to \"invoice.json\"");
            inv1.SaveAsJson("invoice.json");
            //testing the RemoveItem method of the invient class
            //check the previous display to verify that atleast
            //two of the item numbers are used below
            Console.WriteLine("\n*****Testing the RemoveItem()");
            inv1.RemoveItem("108");
            inv1.RemoveItem("109");
            try
            {
                inv1.RemoveItem("108");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(inv1);
        }
    }
}
