using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2. Polymorphism
/// </summary>
namespace Slide21_24
{
    // Slide 23
    class Program
    {
        static void Main(string[] args)
        {
            Student payingStudent = new Student();
            payingStudent.Name = "Megan";
            payingStudent.Credits = 15;

            ScholarshipStudent freeStudent = new ScholarshipStudent();
            freeStudent.Name = "Luke";
            freeStudent.Credits = 15;

            Console.WriteLine("{0}'s tuition is {1}", payingStudent.Name, payingStudent.Tuition.ToString("C"));
            Console.WriteLine("{0}'s tuition is {1}", freeStudent.Name, freeStudent.Tuition.ToString("C"));
        }
    }
}
