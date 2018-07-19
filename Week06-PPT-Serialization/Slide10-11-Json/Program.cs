using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Jason Serialization 2 & Json De-Serialization 2: Add the necessary namespace for [JavaScriptSerializer]
using System.Web.Script.Serialization;

// Jason Serialization 5 & Json De-Serialization 4: Add the necessary namespace for [TextWriter], [StreamWriter] and [TextReader], [StreamReader]
using System.IO;

namespace Slide10_11_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Json Serialization
            // Jason Serialization 1 & Json De-Serialization 1: Add [System.Web.Extensions] reference into [Slide10-11] - [References] *

            // Jason Serialization 3: Create and initialise a serializer object
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // Jason Serialization 6: You will also need a writable stream such as a TextWriter
            TextWriter writer = new StreamWriter("lizard.json");

            // Jason Serialization 7: Use the Serialize method to serialize the object. The method returns a string.
            writer.Write(serializer.Serialize(LizardLib.Lizard.GetLizard()));

            writer.Close();
            #endregion

            #region Json De-Serialization
            //// Jason Serialization 1 & Json De-Serialization 1: Add [System.Web.Extensions] reference into [Slide10-11] - [References] *

            //// Json De-Serialization 3: Create and initialise a serializer object
            //JavaScriptSerializer deserializer = new JavaScriptSerializer();

            //// Json De-Serialization 4: You will also need a writable stream such as a TextWriter
            //TextReader reader = new StreamReader("lizard.json");

            //// Json De-Serialization 5: Use the Serialize method to serialize the object. The method returns a string
            //Console.WriteLine(deserializer.Deserialize<LizardLib.Lizard>(reader.ReadToEnd()));

            //reader.Close();
            #endregion
        }
    }
}
