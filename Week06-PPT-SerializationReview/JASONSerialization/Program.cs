using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// JASON Serialization One Object Step 1: Add the necessary reference into [Reference]
// JASON DeSerialization One Object Step 1: Add the necessary reference into [Reference]
// JASON Serialization List Object Step 1: Add the necessary reference into [Reference]
// JASON DeSerialization List Object Step 1: Add the necessary reference into [Reference]

// JASON Serialization One Object Step 2: Add the necessary namespace
// JASON DeSerialization One Object Step 2: Add the necessary namespace
// JASON Serialization List Object Step 2: Add the necessary namespace
// JASON DeSerialization List Object Step 2: Add the necessary namespace
using System.Web.Script.Serialization;

// JASON Serialization One Object Step 5: Add StudentLibrary namespace
// JASON DeSerialization One Object Step 5: Add StudentLibrary namespace
// JASON Serialization List Object Step 5: Add StudentLibrary namespace
// JASON DeSerialization List Object Step 5: Add StudentLibrary namespace
using StudentLibrary;

// JASON Serialization One Object Step 6: Add FileIO namespace
// JASON DeSerialization One Object Step 6: Add FileIO namespace
// JASON Serialization List Object Step 6: Add FileIO namespace
// JASON DeSerialization List Object Step 6: Add FileIO namespace
using System.IO;


namespace JASONSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- 1. Create JASON Serialization One Object -----");
            Student student = new Student() { Name = "DaeWoong Ryu", StudentNumber = 1003, Domestic = true };
            JasonSerializationOneObject(student, "Student.jason");
            Console.WriteLine("- Student.jason file is created in BIN folder");

            Console.WriteLine();

            Console.WriteLine("----- 2. Create JASON DeSerialization One Object and Display -----");
            JasonDeSerializationOneObject(student, "Student.jason");

            Console.WriteLine();

            Console.WriteLine("----- 3. Create JASON Serialization List Object -----");
            JasonSerializationListObject(Student.Students(), "Students.jason");
            Console.WriteLine("- Students.jason file is created in BIN folder");

            Console.WriteLine();

            Console.WriteLine("----- 4. Create JASON DeSerialization List Object and Display -----");
            JasonDeSerializationListObject(Student.Students(), "Students.jason");
        }

        // JASON Serialization One Object Step 3: Create JasonSerializationOneObject() Method with arguments
        static void JasonSerializationOneObject(Student student, string filename)
        {
            // JASON Serialization One Object Step 4: You will also need a writable stream such as a TextWriter with USING() 
            using (TextWriter writer = new StreamWriter(filename))
            {
                // JASON Serialization One Object Step 7: Create and initialise a serializer object
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                // JASON Serialization One Object Step 8: Use the Serialize method to serialize the object. The method returns a string
                writer.Write(serializer.Serialize(student));

                // JASON Serialization One Object Step 9: writer close
                writer.Close();
            }
        }

        // JASON DeSerialization One Object Step 3: Create JasonDeSerializationOneObject() Method with arguments
        static void JasonDeSerializationOneObject(Student student, string filename)
        {
            // JASON DeSerialization One Object Step 4: You will also need a readable stream such as a TextWriter with USING() 
            using (TextReader reader = new StreamReader(filename))
            {
                // JASON DeSerialization One Object Step 6: Create and initialise a deSerializer object
                JavaScriptSerializer deSerializer = new JavaScriptSerializer();

                // JASON DeSerialization One Object Step 7: Use the Serialize method to serialize the object. The method returns a string
                Console.WriteLine(deSerializer.Deserialize<Student>(reader.ReadToEnd()));

                // JASON DeSerialization One Object Step 8: reader close
                reader.Close();
            }
        }

        // JASON Serialization List Object Step 3: Create JasonSerializationListObject() Method with arguments
        static void JasonSerializationListObject(List<Student> students, string filename)
        {
            // JASON Serialization List Object Step 4: You will also need a writable stream such as a TextWriter with USING()
            using (TextWriter writer = new StreamWriter(filename))
            {
                // JASON Serialization List Object Step 7: Create and initialise a serializer object
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                // JASON Serialization List Object Step 8: Use the Serialize method to serialize the object. The method returns a string
                writer.Write(serializer.Serialize(students));

                // JASON Serialization List Object Step 9: writer close
                writer.Close();
            }
        }

        // JASON DeSerialization List Object Step 3: Create JasonDeSerializationListObject() Method with arguments
        static void JasonDeSerializationListObject(List<Student> students, string filename)
        {
            // JASON DeSerialization List Object Step 4: You will also need a readable stream such as a TextWriter with USING()
            using (TextReader reader = new StreamReader(filename))
            {
                // JASON DeSerialization List Object Step 6: Create and initialise a deSerializer object
                JavaScriptSerializer deSerializer = new JavaScriptSerializer();

                // JASON DeSerialization One Object Step 7: Use the Serialize method to serialize the object. The method returns a string
                List<Student> studentsList = deSerializer.Deserialize<List<Student>>(reader.ReadToEnd());

                // JASON DeSerialization One Object Step 8: Use [foreach] for reading a json file
                foreach(var x in studentsList)
                {
                    Console.WriteLine(x);
                }

                // JASON DeSerialization One Object Step 9: reader close
                reader.Close();
            }
        }
    }
}
