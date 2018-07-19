using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Sample Song -----");
            Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));

            Console.WriteLine("----- Read song4.txt file and Display all -----");
            Library.LoadSong("songs4.txt");
            Library.DisplaySongs();

            Console.WriteLine("----- List of Rock Genre Songs -----");
            SongGenre genre = SongGenre.Rock;
            Library.DisplaySongs(genre);

            Console.WriteLine("----- List of Specific Artist's songs -----");
            Library.DisplaySongs("Bob Dylan");

            Console.WriteLine("----- List of songs 5 Min more -----");
            Library.DisplaySongs(5);
        }
    }
}
