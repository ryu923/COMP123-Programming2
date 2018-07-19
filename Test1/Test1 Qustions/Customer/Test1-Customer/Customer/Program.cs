using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        // 3. Test Harness
        static void Main(string[] args)
        {
            //test the Customer class
            Console.WriteLine("\n*****Testing the Customer Class");
            Console.WriteLine(new Customer("Yuri Gagarin", "416-123-4567"));
            Console.WriteLine(new Customer("Alan Shepard", "416-345-6789", 34.56));
            Console.WriteLine(new Customer("Virgil Grissom", "416-567-8901", 67.09, false));

            //test the Store class
            Console.WriteLine("\n*****Testing the Store Class");
            Console.WriteLine(new Store("Food Basics", "647-124-5678"));

            //testing InsertCustomer method of the invoice class
            Console.WriteLine("\n*****Testing the InsertCustomer() for first store");
            Store store0 = new Store("Fresco", "647-123-4567");
            store0.InsertCustomer(new Customer("Gherman Titov", "647-123-1234", 38, false));
            store0.InsertCustomer(new Customer("John Glenn", "647-123-3456", 46, false));
            store0.InsertCustomer(new Customer("Scott Carpenter", "647-123-7890", 6.01));
            store0.InsertCustomer(new Customer("Andriyan Nikolayev", "647-123-5498", .92, false));
            Console.WriteLine(store0);

            Console.WriteLine("\n*****Testing the InsertCustomer() for second store");
            Store store1 = new Store("Metro", "416-289-5000");
            store1.InsertCustomer(new Customer("Pavel Popovich", "647-123-3215", 49));
            store1.InsertCustomer(new Customer("Walter Schirra", "647-123-7654", 21, true));
            store1.InsertCustomer(new Customer("Gordon Cooper", "647-123-9870", 78, false));
            store1.InsertCustomer(new Customer("Valery Bykovsky", "647-123-3219"));
            store1.InsertCustomer(new Customer("Valentina Tereshkova", "647-123-8790", 45));
            store1.InsertCustomer(new Customer("Joseph Walker", "647-123-0843", 76, false));
            Console.WriteLine(store1);

            //testing the RemoveCustomer method of the Store class
            //check the previous display to verify that atleast 
            //two of the item numbers are used below
            Console.WriteLine("\n*****Testing the RemoveCustomer()");
            store1.RemoveCustomer("508");
            store1.RemoveCustomer("509");

            Console.WriteLine("\n*****Saving to \"customer.txt\"");
            store1.SaveAsText("customer.txt");
            try
            {
                store1.RemoveCustomer("508");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(store1);
        }
    }
}
