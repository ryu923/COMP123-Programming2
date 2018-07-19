using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    class Song
    {
        // PROPERTIES
        public string Artist { get; private set; }
        public SongGenre Genre { get; private set; }
        public double Length { get; private set; }
        public string Title { get; private set; }

        // CONSTRUCTOR
        public Song(string title, string artist, double length, SongGenre genre)
        {
            Title = title;
            Artist = artist;
            Length = length;
            Genre = genre;
        }

        // METHOD
        public override string ToString()
        {
            return string.Format("Title: " + Title + "\n" +
                                 " - Artist: " + Artist + "\n" +
                                 " - Length: " + Length + " Mins\n" +
                                 " - Genre: " + Genre + "\n");
        }
    }
}
