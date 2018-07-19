using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Display List of Created Tweets -----");
            Tweet.Initialize();

            Console.WriteLine("----- Display List of Tweets on the File -----");
            TweetManager.ShowAll();

            Console.WriteLine("----- Display List of Tweets with Specific Tag on the File -----");
            TweetManager.ShowAll("Raptors");
        }
    }
}
