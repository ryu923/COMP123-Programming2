using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweet
{
    class Tweet
    {
        // FIELDS
        private static int CURRENT_ID = 1; // input the static for numbering

        // PROPERTIES
        public string From { get; private set; }
        public string To { get; private set; }
        public string Body { get; private set; }
        public string Tag { get; private set; }
        public string Id { get; private set; }

        // CONSTRUCTOR
        public Tweet(string from, string to, string body, string tag)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = Convert.ToString(CURRENT_ID);

            CURRENT_ID++;
        }

        // ToString() METHOD
        public override string ToString()
        {
            return string.Format("\nID: #" + Id +
                                 "\n - From: " + From +
                                 "\n - To  : " + To +
                                 "\n - Body: " + Body +
                                 "\n - Tag : " + Tag );
        }

        // METHOD
        // This Method for divide words section in a file to read
        public static Tweet Parse(string line)
        {
            string[] words = line.Split();

            // This part is for display whole words in Body section message(words[3]) with space.
            for(int i = 0; i < words.Length; i++)
            {
                words[3] = words[3] + " " + words[i];
            }

            Tweet tweets = new Tweet(words[1], words[2], words[3], words[0]);

            return tweets;
        }
    }
}
