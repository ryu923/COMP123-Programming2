using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[List of basic Tweet Message]");
            TweetManager.Initialize();

            Console.WriteLine("\n\n[List of all Tweet Messages from the file]");
            TweetManager.ShowAll();

            Console.WriteLine("\n\n[List of all Tweet Messages only including specific Tag from the file]");
            TweetManager.ShowAll("Raptors");
        }
    }
}
