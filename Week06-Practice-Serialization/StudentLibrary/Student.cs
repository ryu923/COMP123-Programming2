using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Step 1. Create a [Student] library for JSON and XML
namespace StudentLibrary
{
    public class Student
    {
        // PROPERTIES
        public string Name;
        public int StudentNumber;
        public bool Domestic;

        // CONSTRUCTORs
        public Student()
        {

        }

        public Student(string name, int studentNumber, bool domestic)
        {
            Name = name;
            StudentNumber = studentNumber;
            Domestic = domestic;
        }

        // ToString() METHOD
        public override string ToString()
        {
            return string.Format(" {0, -15} {1} {2}", Name, StudentNumber, Domestic? "Domestic" : "International");
        }

        // METHOD
        public static List<Student> students()
        {
            return new List<Student>()
            {
                new Student() { Name = "David Ryu", StudentNumber = 1000, Domestic = true },
                new Student() { Name = "Candice Cho", StudentNumber = 1001, Domestic = true },
                new Student() { Name = "Micahel Jordan", StudentNumber = 1002, Domestic = true }
            };
        }
    }
}
