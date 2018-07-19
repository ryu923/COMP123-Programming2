using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    class Theater
    {
        // PROPERTIES
        public List<Show> Shows { get; private set; }
        public string Name { get; private set; }

        // CONSTRUCTOR
        public Theater(string name)
        {
            Shows = new List<Show>();
            Name = name;
        }

        // METHODS
        public void AddShow(Show show)
        {
            Shows.Add(show);
        }

        public void PrintShows()
        {
            foreach(Show x in Shows)
            {
                Console.WriteLine(x + "\n");
            }
        }

        public void PrintShows(MovieGenre genre)
        {
            foreach(Show x in Shows)
            {
                if(x.Movie.Genre == genre)
                {
                    Console.WriteLine(x + "\n");
                }
            }
        }

        public void PrintShows(MovieDay day)
        {
            foreach (Show x in Shows)
            {
                if (x.Day == day)
                {
                    Console.WriteLine(x + "\n");
                }
            }
        }

        public void PrintShows(Time time)
        {
            foreach(Show x in Shows)
            {
                if(x.Time.Hours == time.Hours)
                {
                    Console.WriteLine(x + "\n");
                }
            }
        }

        public void PrintShows(string actor)
        {
            foreach(Show x in Shows)
            {
                for(int i = 0; i < x.Movie.Cast.Count; i++ )
                {
                    if(x.Movie.Cast[i] == actor)
                    {
                        Console.WriteLine(x + "\n");
                    }
                }
            }
        }
    }
}
