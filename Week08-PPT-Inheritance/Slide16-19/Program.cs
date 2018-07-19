using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2. Protected Access Modifier
/// </summary>
namespace Slide16_19
{
    // Slide 18
    class Program
    {
        static void Main(string[] args)
        {
            CommittionEmployee salesperson = new CommittionEmployee();
            salesperson.EmpNum = 345;
            salesperson.EmpSal = 20000;
            salesperson.CommissionRate = 0.07;

            Console.WriteLine("\n" + salesperson.GetGreeting());
            Console.WriteLine("Salesperson #{0} salary: {1} per year", salesperson.EmpNum, salesperson.EmpSal.ToString("C"));
            Console.WriteLine("... plus {0} commission on all sales", salesperson.CommissionRate.ToString("P"));
        }
    }
}
