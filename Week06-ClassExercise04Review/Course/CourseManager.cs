using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course
{
    static class CourseManager
    {
        // FIELDS
        public static List<Course> courses = new List<Course>();

        // METHODS
        public static void Display(DisplayOption option, string toMatch="")
        {
            switch(option)
            {
                case DisplayOption.All:
                    foreach(Course x in courses)
                    {
                        Console.WriteLine(x);
                    }
                    break;

                case DisplayOption.Code:
                    foreach(Course x in courses)
                    {
                        if(x.Code == toMatch)
                        {
                            Console.WriteLine(x);
                        }
                    }
                    break;

                case DisplayOption.Name:
                    foreach (Course x in courses)
                    {
                        if (x.Name == toMatch)
                        {
                            Console.WriteLine(x);
                        }
                    }
                    break;

                case DisplayOption.Prerequisite:
                    foreach (Course x in courses)
                    {
                        if (x.Prerequisite == toMatch)
                        {
                            Console.WriteLine(x);
                        }
                    }
                    break;

                case DisplayOption.Semester:
                    foreach (Course x in courses)
                    {
                        if (x.Semester == Convert.ToInt32(toMatch))
                        {
                            Console.WriteLine(x);
                        }
                    }
                    break;
            }
        }

        public static void LoadCourses(string filename)
        {
            TextReader reader = new StreamReader(filename);

            string code = "";

            for( ; ; )
            {
                code = reader.ReadLine();

                if (code == null)
                    break;

                string name = reader.ReadLine();
                string description = reader.ReadLine();
                string semester = reader.ReadLine();
                string prerequisite = reader.ReadLine();

                Course course = new Course(code, name, description, semester, prerequisite);
                courses.Add(course);
            }

            reader.Close();
        }
    }
}
