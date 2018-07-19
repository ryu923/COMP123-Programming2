using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    // XML Serialization 3: Create [Student] library
    public class Student
    {
        // PROPERTIES
        public string Name { get; set; }
        public bool IsFullTime { get; set; }

        // The [System.Xml.Serialization.XmlIgnore] is user for not-including in serializer
        [System.Xml.Serialization.XmlIgnore]
        public string Sin { get; set; }
        public string Major;

        // CONSTRUCTORS
        public Student()
        {

        }

        public Student(string name, bool isFullTime, string sin, string major)
        {
            Name = name;
            IsFullTime = isFullTime;
            Sin = sin;
            Major = major;
        }

        // ToString() METHODS
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, IsFullTime ? "(Full Time)" : "{Part Time}", Major);
        }

        // Add reference to the [Slide08-09-XML] - [References] *
    }
}
