using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cource
{
    /// <summary>
    /// 2. Create [Course] class
    /// </summary>
    class Course
    {
        // FIELDS: No-Fields

        // PROPERTIES
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Semester { get; private set; }
        public string Prerequisites { get; private set; }

        // CONSTRUCTOR
        public Course(string code, string name, string description, string semester, string prerequisites)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Semester = Convert.ToInt32(semester); // [Semester] property is int. Therefore, [string semester] argument should be changed using int32.
            this.Prerequisites = prerequisites;
        }

        // ToString() METHOD
        public override string ToString()
        {
            return string.Format("\n[" + Code + "]" +
                                 "\n- Name          : " + Name +
                                 "\n- Description   : " + Description.Substring(0, 60) + // [.SubString(0, 60)] is capping at 60 letters
                                 "\n- Semester      : " + Semester +
                                 "\n- Prerequisites : " + Prerequisites + "\n");
        }
    }
}
