using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// XML Serialization One Object Step 1: Add the necessary namespace
// XML DeSerialization One Object Step 1: Add the necessary namespace
// XML Serialization List Object Step 1: Add the necessary namespace
// XML DeSerialization List Object Step 1: Add the necessary namespace
using System.Xml.Serialization;

// XML Serialization One Object Step 3: Add StudentLibrary namespace
// XML DeSerialization One Object Step 3: Add StudentLibrary namespace
// XML Serialization List Object Step 3: Add StudentLibrary namespace
// XML DeSerialization List Object Step 3: Add StudentLibrary namespace
using StudentLibrary;

// XML Serialization One Object Step 5: Add FileIO namespace
// XML DeSerialization One Object Step 5: Add FileIO namespace
// XML Serialization List Object Step 5: Add FileIO namespace
// XML DeSerialization List Object Step 5: Add FileIO namespace
using System.IO;

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- 1. Create XML Serialization One Object -----");
            XMLSerializationOneObject();
            Console.WriteLine("- Student.xml file is created in BIN folder");

            Console.WriteLine();

            Console.WriteLine("----- 2. Create XML DeSerialization One Object and Display -----");
            XMLDeSerializationOneObject();

            Console.WriteLine();

            Console.WriteLine("----- 3. Create XML Serialization List Object -----");
            XMLSerializationListObject();
            Console.WriteLine("- Students.xml file is created in BIN folder");

            Console.WriteLine();

            Console.WriteLine("----- 4. Create XML DeSerialization List Object and Display -----");
            XMLDeSerializationListObject();
        }

        static void XMLSerializationOneObject()
        {
            // XML Serialization One Object Step 2: Create and initialize a serializer object
            XmlSerializer SerializerOneObject = new XmlSerializer(typeof(Student)); // Should create StudentLibrary 

            // XML Serialization One Object Step 4: You will also need a writable stream such as a TextWriter
            TextWriter writer = new StreamWriter("Student.xml");

            // XML Serialization One Object Step 6: Use the Serialize method to serialize the object
            SerializerOneObject.Serialize(writer, new Student("David Ryu", 999, true));

            // XML Serialization One Object Step 7: Close writer
            writer.Close();
        }

        static void XMLDeSerializationOneObject()
        {
            // XML DeSerialization One Object Step 2: Create and initialize a serializer object
            XmlSerializer DeSerializerOneObject = new XmlSerializer(typeof(Student));

            // XML DeSerialization One Object Step 4: You will also need a readable stream such as a TextReader
            TextReader reader = new StreamReader("Student.xml");

            // XML DeSerialization One Object Step 6: Use the Deserialize method to de-serialize the object
            Student student = (Student)DeSerializerOneObject.Deserialize(reader);

            // XML DeSerialization One Object Step 7: Display
            Console.WriteLine(student);

            // XML DeSerialization One Object Step 8: Close reader
            reader.Close();
        }

        static void XMLSerializationListObject()
        {
            // XML Serialization List Object Step 2: Create and initialize a serializer object
            XmlSerializer SerializerListObject = new XmlSerializer(typeof(List<Student>));

            // XML Serialization List Object Step 4: You will also need a writable stream such as a TextWriter
            TextWriter writer = new StreamWriter("Students.xml");

            // XML Serialization List Object Step 6: Use the Serialize method to serialize the object
            SerializerListObject.Serialize(writer, Student.Students());

            // XML Serialization List Object Step 7: Close writer
            writer.Close();
        }

        static void XMLDeSerializationListObject()
        {
            // XML DeSerialization List Object Step 2: Create and initialize a serializer object
            XmlSerializer DeSerializerListObject = new XmlSerializer(typeof(List<Student>));

            // XML DeSerialization List Object Step 4: You will also need a readable stream such as a TextReader
            TextReader reader = new StreamReader("Students.xml");

            // XML DeSerialization List Object Step 6: Use the Deserialize method to de-serialize the object
            List<Student> students = (List<Student>)DeSerializerListObject.Deserialize(reader);

            // XML DeSerialization List Object Step 7: Display
            foreach(Student x in students)
            {
                Console.WriteLine(x);
            }

            // XML DeSerialization List Object Step 8: Close reader
            reader.Close();
        }
    }
}
