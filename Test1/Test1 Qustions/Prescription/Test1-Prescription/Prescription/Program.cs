using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prescription
{
    class Program
    {
        // 4. Test Harness
        static void Main(string[] args)
        {
            //test the Drug class
            Console.WriteLine("\n*****Testing the Drug Class");
            Console.WriteLine(new Drug("Aspirin", 85));
            Console.WriteLine(new Drug("Tylenol", 125, DrugForm.Capsule));
            Console.WriteLine(new Drug("Metformin", 250));

            //test the Prescription class
            Console.WriteLine("\n*****Testing the Prescription Class");
            Console.WriteLine(new Prescription("Joanne Fillotti", "Markham Road"));

            //testing InsertDrug method of the Prescription class
            Console.WriteLine("\n*****Testing the InsertDrug()");
            Prescription store0 = new Prescription("Jake Nesovich", "Morningside Avenue", false);
            store0.InsertDrug(new Drug("Oxycontin", 150, DrugForm.Gel));
            store0.InsertDrug(new Drug("Marjuana", 200, DrugForm.Paste));
            store0.InsertDrug(new Drug("Amoxicillin", 350, DrugForm.Capsule));
            store0.InsertDrug(new Drug("Fentanyl", 50, DrugForm.Aerosol));
            Console.WriteLine(store0);

            Console.WriteLine("\n*****Testing the InsertDrug()");
            Prescription store1 = new Prescription("Bindu Ggoel", "Williams Parkway", true);
            store1.InsertDrug(new Drug("Warfarin", 125, DrugForm.Gel));
            store1.InsertDrug(new Drug("Prozac", 300, DrugForm.Paste));
            store1.InsertDrug(new Drug("Ibuprofen", 250));
            store1.InsertDrug(new Drug("Oxycodone", 85, DrugForm.Liquid));
            store1.InsertDrug(new Drug("Ropinirole", 125, DrugForm.Cream));
            store1.InsertDrug(new Drug("Tramadol", 250, DrugForm.Powder));
            Console.WriteLine(store1);

            //testing the RemoveCustomer method of the invient class
            //check the previous display to verify that atleast
            //two of the item numbers are used below
            Console.WriteLine("\n*****Testing the RemoveDrug()");
            store1.RemoveDrug("109");
            store1.RemoveDrug("110");
            try
            {
                store1.RemoveDrug("109");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(store1);
        }
    }
}
