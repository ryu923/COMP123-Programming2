using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 6. Diverse Objects
/// </summary>
namespace Slide33_34
{
    // Slide 33
    class Program
    {
        static void Main(string[] args)
        {
            Student payingStudent = new Student();
            ScholarshipStudent freeStudent = new ScholarshipStudent();
            Employee clerk = new Employee();

            Console.Write("Using Student: ");
            DisplayObjectMessage(payingStudent);

            Console.Write("Using ScholarshipStudent: ");
            DisplayObjectMessage(freeStudent);

            Console.Write("Using Employee: ");
            DisplayObjectMessage(clerk);
        }

        public static void DisplayObjectMessage(Object o)
        {
            Console.WriteLine("Method successfully called");
        }
    }
}
