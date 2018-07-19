using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cource
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read [Week06-ClassExercise04-Courses] file
            CouserManager.LoadCourses("Week06-ClassExercise04-Courses.txt");

            Console.WriteLine("\n1. All courses");
            CouserManager.Display(DisplayOption.All);

            Console.WriteLine("\n--------------------------------------------\n");

            string toSearch = "COMP100";

            Console.WriteLine("\n2. All courses with preresuisite " + toSearch);
            CouserManager.Display(DisplayOption.Prerequisite, toSearch);

            Console.WriteLine("\n--------------------------------------------\n");

            Console.WriteLine("\n3. All courses with code " + toSearch);
            CouserManager.Display(DisplayOption.Code, toSearch);

            Console.WriteLine("\n--------------------------------------------\n");

            toSearch = "Programing I";

            Console.WriteLine("\n4. All courses with name " + toSearch);
            CouserManager.Display(DisplayOption.Name, toSearch);

            Console.WriteLine("\n--------------------------------------------\n");

            toSearch = "2";

            Console.WriteLine("\n5. All courses with semester " + toSearch);
            CouserManager.Display(DisplayOption.Semester, toSearch);
        }
    }
}
