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
        private static int CURRENT_ID = 1;

        // PROPERTIES
        public string From { get; private set; }
        public string To { get; private set; }
        public string Body { get; private set; }
        public string Tag { get; private set; }
        public string Id { get; private set; }


        // CONSTRUCTOR
        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = Convert.ToString(CURRENT_ID);
            CURRENT_ID++;
        }

        // METHODS
        public override string ToString()
        {
            return string.Format("Tweet From: " + From + "\n" +
                                 " - To: " + To + "\n" +
                                 " - Message: " + Body + "\n" +
                                 " - Tag: " + Tag + "\n" + 
                                 " - ID: " + Id + "\n");
        }

        public static Tweet Parse(string line)
        {
            string[] words = line.Split();

            for(int i = 0; i < words.Length; i++)
            {
                words[3] = words[3] + " " + words[i];
            }

            Tweet tweets = new Tweet(words[1], words[2], words[3], words[0]);

            return tweets;
        }

        public static void Initialize()
        {
            Tweet t1 = new Tweet("Candice", "David", "Vancuver is a good place to live.", "Vancuver");
            Tweet t2 = new Tweet("David", "Candice", "Toronto is a good place to live.", "Toronto");
            Tweet t3 = new Tweet("Michael", "David", "Chicago is a good place to live.", "Chicago");
            Tweet t4 = new Tweet("David", "Michael", "Seoul is a good place to live.", "Seoul");
            Tweet t5 = new Tweet("David", "All", "I live in a good place.", "New York");

            List<Tweet> tweetlist = new List<Tweet>();

            tweetlist.Add(t1);
            tweetlist.Add(t2);
            tweetlist.Add(t3);
            tweetlist.Add(t4);
            tweetlist.Add(t5);

            int i = 0;

            while (i < tweetlist.Count)
            {
                Console.WriteLine(tweetlist[i]);

                i++;
            }
        }
    }
}
