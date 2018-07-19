using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongDemo
{
    /// <summary>
    /// 2. Create the Song class
    /// </summary>
    class Song
    {

        // FIELDS : No-fields

        // Properties
        public string Artist { get; private set; }
        public SongGenre SongGenre { get; private set; }
        public double Length { get; private set; }
        public string Title { get; private set; }

        // CONSTRUCTOR
        public Song(string title, string artist, double length, SongGenre genre)
        {
            this.Title = title;
            this.Artist = artist;
            this.Length = length;
            this.SongGenre = genre;
        }

        // ToString() METHOD
        public override string ToString()
        {
            return string.Format("- {0, -35} by {1, -20} : {2:F2} mins, {3, -10}", Title, Artist, Length, SongGenre);
        }
    }
}
