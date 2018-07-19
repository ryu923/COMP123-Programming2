using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add using statement
using System.IO;

namespace Cource
{
    /// <summary>
    /// 3. Create [CourseManager] class
    /// </summary>
    static class CouserManager
    {
        // FIELDS
        public static List<Course> courses = new List<Course>();

        // PROPERTIES: No-Properties

        // CONSTRUCTOR: No-Constructor

        // METHODS
        public static void Display(DisplayOption option, string toMatch="")
        {
            switch(option)
            {
                case DisplayOption.All:
                    foreach(Course c in courses)
                    {
                        Console.WriteLine(c);
                    }
                    break;

                case DisplayOption.Code:
                    foreach (Course c in courses)
                    {
                        if(c.Code == toMatch)
                        {
                            Console.WriteLine(c);
                        }
                    }
                    break;

                case DisplayOption.Name:
                    foreach (Course c in courses)
                    {
                        if(c.Name == toMatch)
                        {
                            Console.WriteLine(c);
                        }
                    }
                    break;

                case DisplayOption.Prerequisite:
                    foreach (Course c in courses)
                    {
                        // This [c.Prerequisites.Contains(toMatch)] is for checking the property has contain specific second argument
                        if (c.Prerequisites.Contains(toMatch))
                        {
                            Console.WriteLine(c);
                        }
                    }
                    break;

                case DisplayOption.Semester:
                    foreach (Course c in courses)
                    {
                        if(c.Semester == Convert.ToInt32(toMatch))
                        {
                            Console.WriteLine(c);
                        }
                    }
                    break;
            }
        }

        public static void LoadCourses(string filename)
        {
            // Declare [TextReader] argument for reading the file
            TextReader reader = new StreamReader(filename);

            // The condition for termination
            string code = "";

            for(;;)
            {
                code = reader.ReadLine();
                if (code == null)
                    break;

                // Read more values in the file
                string name = reader.ReadLine();
                string description = reader.ReadLine();
                string semester = reader.ReadLine();
                string prerequisites = reader.ReadLine();

                // User variables to create a [Course] object and add to the [List<Course>()]
                Course course = new Course(code, name, description, semester, prerequisites);
                courses.Add(course);
            }

            // Close the file
            reader.Close();
        }
    }
}
