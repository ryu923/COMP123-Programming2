using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Sample Test]");
            Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));

            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            // Read File
            Library.LoadSongs("songs4.txt");

            Console.WriteLine("[All songs]");
            Library.DisplaySongs();

            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine("[List of Rocks]");
            SongGenre genre = SongGenre.Rock;
            Library.DisplaySongs(genre);

            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine("[List of Bob Dylan's songs]");
            Library.DisplaySongs("Bob Dylan");

            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine("[List of songs which has length longer than 5 mins length]");
            Library.DisplaySongs(5);
        }
    }
}
