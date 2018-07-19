using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    class Threater
    {
        // FIELDS : No-Fields

        // PROPERTIES
        public List<Show> Shows { get; private set; }
        public string Name { get; private set; }

        // COSTRUCTOR
        public Threater(string name)
        {
            this.Name = name;
            this.Shows = new List<Show>();
        }

        // METHODS
        public void AddShow(Show show)
        {
            Shows.Add(show);
        }

        public void PrintShows()
        {
            foreach(Show s in Shows)
            {
                Console.WriteLine(s + "\n");
            }
        }

        public void PrintShows(MovieGenre genre)
        {
            foreach (Show s in Shows)
            {
                if(s.Movie.Genre == genre)
                {
                    Console.WriteLine(s + "\n");
                }
            }
        }

        public void PrintShows(MovieDay day)
        {
            foreach(Show s in Shows)
            {
                if(s.Day == day)
                {
                    Console.WriteLine(s + "\n");
                }
            }
        }

        public void PrintShows(Time time)
        {
            foreach(Show s in Shows)
            {
                if(s.Time.Hours == time.Hours)
                {
                    Console.WriteLine(s + "\n");
                }
            }
        }

        public void PrintShows(string actor)
        {
            foreach(Show s in Shows)
            {
                for(int i = 0; i < s.Movie.Cast.Count; i++)
                {
                    if(s.Movie.Cast[i] == actor)
                    {
                        Console.WriteLine(s + "\n");
                    }
                }
            }
        }
    }
}
