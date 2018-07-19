using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Course
    {
        // PROPERTIES
        public string Code { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public string Prerequisite { get; private set; }
        public int Semester { get; private set; }

        // CONSTRUCTOR
        public Course(string code, string name, string description, string semester, string prerequisites)
        {
            Code = code;
            Name = name;
            Description = description;
            Semester = Convert.ToInt32(semester);
            Prerequisite = prerequisites;
        }

        // METHODS
        public override string ToString()
        {
            return string.Format("[" + Name + "]" + "\n" +
                                 " - Code: " + Code + "\n" + 
                                 " - Semester: " + Semester + "\n" + 
                                 " - Prerequisite: " + Prerequisite + "\n" + 
                                 " - Description: " + Description.Substring(0, 60) + "\n");
        }
    }
}
