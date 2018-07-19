﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    class Movie
    {
        // FIELDS : No-Fields

        // PROPERTIES
        public int Length { get; private set; }
        public string Title { get; private set; }
        public MovieGenre Genre { get; private set; }
        public List<string> Cast { get; private set; }

        // CONSTRUCTOR
        public Movie(string name, int length)
        {
            this.Title = name;
            this.Length = length;

            // Initialize the Cast property to 
            this.Cast = new List<string>();
        }

        // METHODS
        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre(MovieGenre genre)
        {
            this.Genre = genre;
        }

        // ToString() METHOD
        public override string ToString()
        {
            return string.Format("[" + Title + "]" + 
                                 "\n- Length: " + Length +
                                 "\n- Genre : " + Genre + 
                                 "\n- Cast  : " + String.Join(", ", Cast));
        }
    }
}
