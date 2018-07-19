using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tweet
{
    class TweetManager
    {
        // FIELDS
        private static List<Tweet> TWEETS;
        private static string FILENAME = "Week04-Assignment02-TweetReview.txt";

        // CONSTRUCTOR
        static TweetManager()
        {
            // a. Initialize the tweets field to a new list of tweets
            TWEETS = new List<Tweet>();

            // b. Opens the file specified by the filename field for reading
            TextReader reader = new StreamReader(FILENAME);

            // c. Using a looping structure it does the following:
            string line = "";

            for( ; ; )
            {
                // c.i. Reads one line from the file
                line = reader.ReadLine();

                // c.iv. This is repeated until the input from the file is empty (null).
                if (line == null)
                    break;

                // ii. Passes this line to the static Parse() method of the Tweet class to create a tweet object
                // iii.The resulting object is added to the tweet collection
                TWEETS.Add(Tweet.Parse(line));
            }

            reader.Close();
        }

        // METHOD
        public static void Initialize()
        {
            Tweet t1 = new Tweet("Candice", "David", "Vancuver is a good place to live.", "Vancuver");
            Tweet t2 = new Tweet("David", "Candice", "Toronto is a good place to live.", "Toronto");
            Tweet t3 = new Tweet("Michael", "David", "Chicago is a good place to live.", "Chicago");
            Tweet t4 = new Tweet("David", "Michael", "Seoul is a good place to live.", "Seoul");
            Tweet t5 = new Tweet("David", "All", "I live in a good place.", "New York");

            TWEETS.Add(t1);
            TWEETS.Add(t2);
            TWEETS.Add(t3);
            TWEETS.Add(t4);
            TWEETS.Add(t5);

            int i = 0;

            while(i < TWEETS.Count)
            {
                Console.WriteLine(TWEETS[i]);

                i++;
            }
        }

        public static void ShowAll()
        {
            int i = 0;

            do
            {
                Console.WriteLine(TWEETS[i]);

                i++;
            } while (i < TWEETS.Count);
        }

        public static void ShowAll(string tag)
        {
            foreach(Tweet x in TWEETS)
            {
                if(x.Tag == tag)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
