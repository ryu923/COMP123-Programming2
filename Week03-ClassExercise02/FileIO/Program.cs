using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Writing Step 1 & Reading Step 1 (Common): Add the necessary using statement
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write File
            WriteFile("SampleText.txt");

            // Read File
            ReadFile("SampleText.txt");
            
        }

        public static void WriteFile(string fileName)
        {
            // Writing Step 2 : Declare and initialize the object to write
            TextWriter writer = new StreamWriter("SampleText.txt");

            // Writing Step 3 : Do some writing
            writer.WriteLine("David");
            writer.WriteLine(DateTime.Today);

            // Writing Step 4 : Now close the file
            writer.Close();
        }

        public static void ReadFile(string fileName)
        {
            // Writing Step 2 : Declare and initialize the object to read
            TextReader reader = new StreamReader("SampleText.txt");

            // Writing Step 3 : Do some reading
            string text = "";

            while(text != null)
            {
                Console.WriteLine($"{text} ");
                text = reader.ReadLine();
            }

            // Writing Step 4 : Now close the file
            reader.Close();
        }
    }
}
