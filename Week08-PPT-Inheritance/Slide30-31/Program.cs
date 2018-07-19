using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 5. Implicit Reference Conversions
/// </summary>
namespace Slide30_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee clerk = new Employee();
            clerk.EmpNum = 234;
            DisplayGreeting(clerk);

            CommissionEmployee salesperson = new CommissionEmployee();
            salesperson.EmpNum = 345;
            DisplayGreeting(salesperson);
        }

        public static void DisplayGreeting(Employee emp)
        {
            Console.WriteLine("Hi there from #" + emp.EmpNum);
            Console.WriteLine(emp.GetGreeting());
        }
    }
}
