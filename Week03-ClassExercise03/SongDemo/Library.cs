using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add using statement
using System.IO;


namespace SongDemo
{
    /// <summary>
    /// 3. Create the Library class
    /// </summary>
    class Library
    {
        // FIELDS
        private static List<Song> songs = new List<Song>();

        // PROPERTIES : No-Properties

        // CONSTRUCTOR : No-Constructor

        // METHODS
        // The way of listing an object : Loops(DO-WHILE, WHILE, and FOR) and FOREACH **
        public static void DisplaySongs()
        {
            int i = 0;

            // Using DO-WHILE Loop
            do
            {
                Console.WriteLine(songs[i]);

                i++;
            } while (i < songs.Count);
        }

        public static void DisplaySongs(double longerThan)
        {
            int i = 0;

            // Using WHILE Loop
            while (i < songs.Count)
            {
                if(songs[i].Length > longerThan)
                {
                    Console.WriteLine(songs[i]);
                }

                i++;
            }
        }

        public static void DisplaySongs(SongGenre genre)
        {
            // Using FOR Loop
            for (int i =0; i < songs.Count; i++)
            {
                if(songs[i].SongGenre == genre)
                {
                    Console.WriteLine(songs[i]);
                }
            }
        }

        public static void DisplaySongs(string artist)
        {
            // Using FOREACH Loop
            foreach (Song s in songs)
            {
                if (s.Artist == artist)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void LoadSongs(string fileName)
        {
            // Declare four string variable to store the four reads
            TextReader reader = new StreamReader(fileName);

            // The first read is the title of the song. You should use this as a check for termination condition
            string title = "";

            for ( ; ; )
            {
                title = reader.ReadLine();
                if (title == null)
                    break;

                // Do three more read and assign them to the appropriate variables
                string artist = reader.ReadLine();
                string length = reader.ReadLine();
                string genre = reader.ReadLine();

                // Use the four variables to create a Song object (you will have to convert the third to a double and the fourth to a SongGenre)
                Song music = new Song(title, artist, Convert.ToDouble(length), (SongGenre)Enum.Parse(typeof(SongGenre), genre));
                songs.Add(music);
            }    
        }
    }
}
