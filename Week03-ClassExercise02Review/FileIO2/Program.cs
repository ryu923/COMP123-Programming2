using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write 1 & Read 1: Common Statement
using System.IO;

namespace FileIO2
{
    class Program
    {
        public static void WriteFile(string fileName)
        {
            // Write 2
            TextWriter writer = new StreamWriter(fileName);

            // Write 3
            writer.WriteLine("David Ryu");
            writer.WriteLine(DateTime.Now);

            // Write 4
            writer.Close();
        }

        public static void ReadFile(string fileName)
        {
            // Read 2
            TextReader reader = new StreamReader(fileName);

            // Read 3
            string text = "";

            while(text != null)
            {
                Console.WriteLine($"{text}");
                text = reader.ReadLine();
            }

            // Read 4
            reader.Close();
        }

        static void Main(string[] args)
        {
            // Write 5
            WriteFile("WriteSample2.txt");

            // Read 5
            ReadFile("WriteSample2.txt");
        }
    }
}
