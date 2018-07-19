using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        // 7. Main Class
        static void Main(string[] args)
        {
            // Create a new deck and Hand
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine("[Original Deck]");
            Console.WriteLine(deck.ToString());

            Console.WriteLine();

            // Shuffle deck
            Console.WriteLine("[Shuffled Deck]");
            deck.Shuffle();
            Console.WriteLine(deck.ToString());

            // Deal1 for Hand
            Console.WriteLine("[Deal1 for Hand]");
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            // Deck after Deal1
            Console.WriteLine("[Deck after Deal1]");
            Console.WriteLine(deck.ToString());

            // Deal1 for Hand 2
            Console.WriteLine("[Deal1 for Hand2]");
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            // Deck after Deal1 2
            Console.WriteLine("[Deck after Deal1 2]");
            Console.WriteLine(deck.ToString());

            // Additional Task3
            Console.WriteLine("----- Addtional Tasks -----\n");

            Console.WriteLine("[Deal5 for Hand]");
            hand = deck.Deal5();
            Console.WriteLine(hand.ToString());

            Console.WriteLine("[Deal5 Highest Card]");
            hand.HighestCards(hand);
        }
    }
}
