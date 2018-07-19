using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// XML Serialization 1 & XML De-Serialization 1: Add the necessary namespace for [XmlSerializer]
using System.Xml.Serialization;

// XML Serialization 5 & XML De-Serialization 3cs: Add the necessary namespace for [TextWriter], [StreamWriter] and [TextReader], [StreamReader].
using System.IO;

namespace Slide08_09_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            #region XML Serialization
            // XML Serialization 2: Create and initialise a serializer object
            XmlSerializer serializer = new XmlSerializer(typeof(StudentLib.Student));

            // XML Serialization 4: You will also need a writable stream such as a TextWriter (Create [student.xml] file)
            TextWriter writer = new StreamWriter("student.xml");

            // XML Serialization 6: Use the Serialize method to serialize the object
            serializer.Serialize(writer, new StudentLib.Student("David Ryu", true, "123-456-7890", "Software Engineering"));

            // XML Serialization 7: Close writer
            writer.Close();
            #endregion

            #region XML De-Serialization
            // XML De-Serialization 2: Create and initialise a serializer object
            XmlSerializer deserializer = new XmlSerializer(typeof(StudentLib.Student));

            // XML De-Serialization 3: You will also need a readable stream such as a TextReader
            TextReader reader = new StreamReader("student.xml");

            // XML De-Serialization 4: Use the Deserialize method to de-serialize the object
            StudentLib.Student student = (StudentLib.Student)deserializer.Deserialize(reader);
            Console.WriteLine(student);

            reader.Close();
            #endregion
        }
    }
}
