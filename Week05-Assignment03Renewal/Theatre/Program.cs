using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List of Movies
            // Add Movies
            Console.WriteLine("< List of Movies >\n");

            Movie m1 = new Movie("Jubgement Day", 105);
            m1.AddActor("Arnold Schwarzenegger");
            m1.AddActor("Linda Hamilton");
            m1.SetGenre(MovieGenre.Horror | MovieGenre.Action); // Assign multiple genre
            Show s1 = new Show(m1, MovieDay.Mon, 5.95, new Time(11, 35, 0));
            Console.WriteLine(s1);

            Console.WriteLine();

            Movie m2 = new Movie("Godzilla 2014", 123);
            m2.AddActor("Aaron Johnson");
            m2.AddActor("Ken Watanabe");
            m2.AddActor("Elizabeth Olsen");
            m2.SetGenre(MovieGenre.Action);
            Show s2 = new Show(m2, MovieDay.Mon, 6.89, new Time(15, 5, 0));
            Console.WriteLine(s2);

            Console.WriteLine();

            Movie m3 = new Movie("Trancendence", 120);
            m3.AddActor("Johnny Depp");
            m3.AddActor("Morgan Freeman");
            m3.SetGenre(MovieGenre.Comedy);
            Show s3 = new Show(m3, MovieDay.Sun, 7.87, new Time(18, 5, 0));
            Console.WriteLine(s3);

            Console.WriteLine();

            Movie m4 = new Movie("The Shawshank Redemption", 120);
            m4.AddActor("Tim Robbins");
            m4.AddActor("Morgan Freeman");
            m4.SetGenre(MovieGenre.Action);
            Show s4 = new Show(m4, MovieDay.Sun, 8.87, new Time(14, 5, 0));
            Console.WriteLine(s4);

            Console.WriteLine();

            Movie m5 = new Movie("Olympus Has Fallen", 120);
            m5.AddActor("Gerard Butler");
            m5.AddActor("Morgan Freeman");
            m5.SetGenre(MovieGenre.Action);
            Show s5 = new Show(m5, MovieDay.Sun, 8.87, new Time(16, 5, 0));
            Console.WriteLine(s5);

            Console.WriteLine();

            Movie m6 = new Movie("The Mask of Zorro", 136);
            m6.AddActor("Antonio Banderas");
            m6.AddActor("Anthony Hopkins");
            m6.AddActor(" Catherine Zeta-Jones");
            m6.SetGenre(MovieGenre.Action | MovieGenre.Romance);
            Show s6 = new Show(m6, MovieDay.Sun, 8.87, new Time(16, 5, 0));
            Console.WriteLine(s6);

            Console.WriteLine();

            Movie m7 = new Movie("Four Weddings and a Funeral", 117);
            m7.AddActor("Hugh Grant");
            m7.AddActor("Andie MacDowell");
            m7.AddActor("Kristin Scott Thomas");
            m7.SetGenre(MovieGenre.Comedy | MovieGenre.Romance);
            Show s7 = new Show(m7, MovieDay.Sat, 8.87, new Time(15, 5, 0));
            Console.WriteLine(s7);

            Console.WriteLine();

            Movie m8 = new Movie("You've Got Mail", 119);
            m8.AddActor("Tom Hanks");
            m8.AddActor("Meg Ryan");
            m8.SetGenre(MovieGenre.Comedy | MovieGenre.Romance);
            Show s8 = new Show(m1, MovieDay.Sat, 8.87, new Time(15, 5, 0));
            Console.WriteLine(s8);
            #endregion

            Console.WriteLine("\n===========================================\n");

            #region List of Movies sort by Theater
            Console.WriteLine("< List of Movies in Eglinton Theater >\n");

            Theater eglinton = new Theater("Cineplex");

            eglinton.AddShow(s1);
            eglinton.AddShow(s2);
            eglinton.AddShow(s3);
            eglinton.AddShow(s4);

            eglinton.PrintShows();

            Console.WriteLine("\n< List of Movies in North York Theater >\n");

            Theater northYork = new Theater("AMB");

            northYork.AddShow(s5);
            northYork.AddShow(s6);
            northYork.AddShow(s7);
            northYork.AddShow(s8);

            northYork.PrintShows();
            #endregion

            Console.WriteLine("\n===========================================\n");

            #region List of Movies by specific day
            Console.WriteLine("< List of Movies on Sunday in Eglinton Theater >\n");
            eglinton.PrintShows(MovieDay.Sun);

            Console.WriteLine("\n< List of Movies on Saturday in North York Theater >\n");
            northYork.PrintShows(MovieDay.Sat);
            #endregion

            Console.WriteLine("\n===========================================\n");

            #region List of Movies by specific genre
            Console.WriteLine("< List of Action Movies in Eglinton Theater >\n");
            eglinton.PrintShows(MovieGenre.Action);

            Console.WriteLine("\n< List of Action Movies in North York Theater >\n");
            northYork.PrintShows(MovieGenre.Action);
            #endregion

            Console.WriteLine("\n===========================================\n");

            #region List of Movies by specific genre
            Console.WriteLine("< List of Action Movies in Eglinton Theater >\n");
            eglinton.PrintShows(MovieGenre.Action);

            Console.WriteLine("\n< List of Action Movies in North York Theater >\n");
            northYork.PrintShows(MovieGenre.Action);

            Console.WriteLine("< List of Comedy Movies in Eglinton Theater >\n");
            eglinton.PrintShows(MovieGenre.Comedy);

            Console.WriteLine("\n< List of Comedy Movies in North York Theater >\n");
            northYork.PrintShows(MovieGenre.Comedy);

            Console.WriteLine("\n< List of Action and Romance Movies in North York Theater >\n");
            northYork.PrintShows(MovieGenre.Action | MovieGenre.Romance);
            #endregion

            Console.WriteLine("\n===========================================\n");

            #region List of Movies by specific actor
            Console.WriteLine("< List of Morgan Freeman's Movies in Eglinton Theater >\n");
            eglinton.PrintShows("Morgan Freeman");
            #endregion

            Console.WriteLine("\n===========================================\n");

            #region List of Movies by specific Time
            Console.WriteLine("< List of Movies start in 14:05:00 >\n");
            eglinton.PrintShows(new Time(14, 5, 0));
            #endregion
        }
    }
}
