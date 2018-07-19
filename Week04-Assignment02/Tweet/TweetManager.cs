using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add using statement
using System.IO;

namespace Tweet
{
    class TweetManager
    {
        // FIELDS
        private static List<Tweet> TWEETS;
        private static string FILENAME = "Week04-Assignment02-Tweet.txt";

        // CONSTRUCTOR
        static TweetManager()
        {
            TWEETS = new List<Tweet>();

            // Open the specific file
            TextReader reader = new StreamReader(FILENAME);

            string line = "";

            for(;;)
            {
                // Reads one line from the file
                line = reader.ReadLine();

                // This is repeated until the input from the file is empty (null)
                if (line == null)
                    break;

                // Passes this line to the static Parse() method of the Tweet class to create a tweet object
                // The resulting object is added to the tweet collection
                TWEETS.Add(Tweet.Parse(line));
            }
        }

        // METHOD
        public static void Initialize()
        {
            Tweet t1 = new Tweet("Candice", "David", "Vancuver is a good place to live.", "Vancuver");
            Tweet t2 = new Tweet("David", "Candice", "Toronto is a good place to live.", "Toronto");
            Tweet t3 = new Tweet("Michael", "David", "Chicago is a good place to live.", "Chicago");
            Tweet t4 = new Tweet("David", "Michael", "Seoul is a good place to live.", "Seoul");
            Tweet t5 = new Tweet("David", "All", "I live in a good place.", "New York");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
        }

        public static void ShowAll()
        {
            foreach(Tweet t in TWEETS)
            {
                Console.WriteLine(t);
            }
        }

        public static void ShowAll(string tag)
        {
            foreach(Tweet t in TWEETS)
            {
                if(t.Tag == tag)
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
