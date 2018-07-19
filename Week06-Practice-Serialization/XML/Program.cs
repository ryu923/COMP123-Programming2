using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Step 3. Add a [using StudentLibrary;] namespace: [References] -> [Add Reference] -> [StudentLibrary]
using StudentLibrary;

// Step 6. Add [using System.Xml;] and [using System.Xml.Serialization;] namespaces: [References] -> [Add Reference] -> [System.XML.Serialization]
using System.Xml;
using System.Xml.Serialization;

// Step 8. Add an [using System.IO;] namespace
using System.IO;


// Step 2. Create a [XML] Project
namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Create XML Serialization");
            XmlSerialization();
            Console.WriteLine("- Student.xml file is created in BIN folder");

            Console.WriteLine("\n2. Create XML DeSerialization and Display");
            XmlDeSerialization();

            Console.WriteLine("\n3. Create XML One Serialization");
            XmlOneSerialization();
            Console.WriteLine("- StudentOne.xml file is created in BIN folder");

            Console.WriteLine("\n4. Create XML One DeSerialization and Display");
            XmlOneDeSerialization();
        }

        // Step 4. Create a [XmlSerialization] Method
        static void XmlSerialization()
        {
            // Step 5. Create a xmlSerializer object
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));

            // Step 7. Serialize and save to file
            TextWriter writer = new StreamWriter("Student.xml");

            xmlSerializer.Serialize(writer, Student.students());

            // Step 9. Writer close
            writer.Close();
        }

        // Step 10. Create a [XmlDeSerialization] Method
        static void XmlDeSerialization()
        {
            // Step 11. Create a xmlDeSerializer object
            XmlSerializer xmlDeSerializer = new XmlSerializer(typeof(List<Student>));

            // Step 12. DeSerialize from a file
            TextReader reader = new StreamReader("Student.xml");

            List<Student> students = (List<Student>)xmlDeSerializer.Deserialize(reader);

            foreach(var item in students)
            {
                Console.WriteLine(item);
            }

            // Step 13. reader close
            reader.Close();
        }

        // Additional Tasks
        static void XmlOneSerialization()
        {
            XmlSerializer xmlOneSerilizer = new XmlSerializer(typeof(Student));

            TextWriter writer = new StreamWriter("StudentOne.xml");

            xmlOneSerilizer.Serialize(writer, new Student("DaeWoong Ryu", 1003, true));

            writer.Close();
        }

        static void XmlOneDeSerialization()
        {
            XmlSerializer xmlOneDeSerilizer = new XmlSerializer(typeof(Student));

            TextReader reader = new StreamReader("StudentOne.xml");

            Student student = (Student)xmlOneDeSerilizer.Deserialize(reader);
            Console.WriteLine(student);

            reader.Close();
        }
    }
}
