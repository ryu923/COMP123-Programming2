using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Song
{
    class Library
    {
        // FIELDS
        private static List<Song> songs = new List<Song>();
        
        // METHODS
        public static void DisplaySongs()
        {
            int i = 0;

            do
            {
                Console.WriteLine(songs[i]);

                i++;
            } while (i < songs.Count);
        }

        public static void DisplaySongs(double longerThan)
        {
            int i = 0;

            while(i < songs.Count)
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
            for(int i = 0; i < songs.Count; i++)
            {
                if(songs[i].Genre == genre)
                {
                    Console.WriteLine(songs[i]);
                }
            }
        }

        public static void DisplaySongs(string artist)
        {
            foreach(Song x in songs)
            {
                if(x.Artist == artist)
                {
                    Console.WriteLine(x);
                }
            }
        }

        public static void LoadSong(string fileName)
        {
            TextReader reader = new StreamReader(fileName);

            // Declare four string variable to store the four reads
            string title = "";

            for( ; ; )
            {
                // The first read is the title of the song. You should use this as a check for termination condition
                title = reader.ReadLine();

                if (title == null)
                    break;

                // Do three more read and assign them to the appropriate variables
                string artist = reader.ReadLine();
                string length = reader.ReadLine();
                string genre = reader.ReadLine();

                // Use the four variables to create a Song object(you will have to convert the third to a double and the fourth to a SongGenre)
                Song music = new Song(title, artist, Convert.ToDouble(length), (SongGenre)Enum.Parse(typeof(SongGenre), genre));

                // Add the above object to the collection
                songs.Add(music);
            }
        }
    }
}
