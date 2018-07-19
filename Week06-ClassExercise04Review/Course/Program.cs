using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseManager.LoadCourses("Week06-ClassExercise04Review-Courses.txt");

            Console.WriteLine("----- All courses -----");
            CourseManager.Display(DisplayOption.All);

            Console.WriteLine();

            string toSearch = "COMP100";
            Console.WriteLine("----- With prerequsite " + toSearch + "-----");
            CourseManager.Display(DisplayOption.Prerequisite, toSearch);

            Console.WriteLine();

            Console.WriteLine("----- With title " + toSearch + "-----");
            CourseManager.Display(DisplayOption.Code, toSearch);

            Console.WriteLine();

            toSearch = "Programing I";
            Console.WriteLine("----- With name " + toSearch + "-----");
            CourseManager.Display(DisplayOption.Name, toSearch);

            Console.WriteLine();

            toSearch = "2";
            Console.WriteLine("----- In semester " + toSearch + "-----");
            CourseManager.Display(DisplayOption.Semester, toSearch);
        }
    }
}
