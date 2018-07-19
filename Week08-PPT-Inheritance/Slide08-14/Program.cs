using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1. Extending Classes
/// </summary>
namespace Slide08_14
{
    class Program
    {
        // Slide 13
        static void Main(string[] args)
        {
            Employee clerk = new Employee();
            clerk.EmpNum = 123;
            clerk.EmpSal = 30000.00;

            CommittionEmployee salesperson = new CommittionEmployee();
            salesperson.EmpNum = 234;
            salesperson.EmpSal = 20000;
            salesperson.CommissionRate = 0.07;

            Console.WriteLine("\n" + clerk.GetGreeting());
            Console.WriteLine("Clerk #{0} salary: {1} per year", clerk.EmpNum, clerk.EmpSal.ToString("C"));

            Console.WriteLine("\n" + salesperson.GetGreeting());
            Console.WriteLine("Salesperson #{0} salary: {1} per year", salesperson.EmpNum, salesperson.EmpSal.ToString("C"));
            Console.WriteLine("... plus {0} commission on all sales", salesperson.CommissionRate.ToString("P"));
        }
    }
}
