using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write 1 & Read 1: Common Statement
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write
            // Write 2: Declare and initialise the object to write
            TextWriter writer = new StreamWriter("WriteSample.txt");

            // Write 3: Do some writing
            writer.Write("Mulroney");
            writer.WriteLine("Harper");

            // Write 4: Now close the file
            writer.Close();
            #endregion

            #region Read
            // Read 2: Declare and initialise the object to read
            TextReader reader = new StreamReader("WriteSample.txt");

            // Read 3: Do some reading
            string text = "";
            
            while(text != null)
            {
                Console.WriteLine($"{text} ");
                text = reader.ReadLine();
            }

            // Read 4: Now close the file
            reader.Close();
            #endregion
        }
    }
}
