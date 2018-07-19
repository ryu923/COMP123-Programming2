using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Step 3. Add a [using StudentLibrary;] namespace: [References] -> [Add Reference] -> [StudentLibrary]
using StudentLibrary;

// Step 5. Add a [using System.IO;] namespace
using System.IO;

// Step 7. Add a [using System.Web.Script.Serialization;] namespace: [References] -> [Add Reference] -> [System.Web.Extensions]
using System.Web.Script.Serialization;


// Step 2. Create [Json] Project
namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Create Json Serialization");
            JsonSerialization(Student.students(), "Student.json");
            Console.WriteLine("- Student.json file is created in BIN folder");

            Console.WriteLine("\n2. Create Json DeSerialization and Display");
            JsonDeSerialization("Student.json");

            Student student = new Student() { Name = "DaeWoong Ryu", StudentNumber = 1003, Domestic = true };

            Console.WriteLine("\n3. Create Json One Serialization");
            JsonOneSerialization(student, "StudentOne.json");
            Console.WriteLine("- StudentOne.json file is created in BIN folder");

            Console.WriteLine("\n4. Create Json DeSerialization and Display");
            JsonOneDeSerialization(student, "StudentOne.json");
        }

        // Step 3. Create a [JsonSerialization] Method
        static void JsonSerialization(List<Student> students, string filename)
        {
            // Step 4. Serialize and save to jason file and add a [System.IO] namespace
            using (TextWriter writer = new StreamWriter(filename))
            {
                // Step 6. Create a jsonSerializer object and add a [JavaScriptSerializer] namespace
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();

                writer.WriteLine(jsonSerializer.Serialize(students));

                // Step 8. Writer close
                writer.Close();
            } 
        }

        // Step 9. Create a [JsonDeSerialization] Method
        static void JsonDeSerialization(string filename)
        {
            // Step 10. Deserialize and open jason file
            using (TextReader reader = new StreamReader(filename))
            {
                // Step 11. Create a DeSerializer object
                JavaScriptSerializer deSerializer = new JavaScriptSerializer();

                // Step 12. Create [result] variable
                List<Student> result = deSerializer.Deserialize<List<Student>>(reader.ReadToEnd());

                // Step 13. Create [foreach] for reading a json file
                foreach(var item in result)
                {
                    Console.WriteLine(item);
                }

                // Step 14. Reader close
                reader.Close();
            }
        }

        // Additional Tasks
        static void JsonOneSerialization(Student student, string filename)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                writer.WriteLine(serializer.Serialize(student));

                writer.Close();
            }
        }

        static void JsonOneDeSerialization(Student student, string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                JavaScriptSerializer deSerializer = new JavaScriptSerializer();

                Console.WriteLine(deSerializer.Deserialize<Student>(reader.ReadToEnd()));

                reader.Close();
            }
        }
    }
}
