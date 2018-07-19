using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 4. Base Class Methods
/// </summary>
namespace Slide26_28
{
    // Slide 27
    class Program
    {
        static void Main(string[] args)
        {
            CommittionEmployee salesperson = new CommittionEmployee();

            salesperson.EmpNum = 345;

            Console.WriteLine(salesperson.GetGreeting());
        }
    }
}
