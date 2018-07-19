using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine(deck.ToString());

            Console.WriteLine();

            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            Console.WriteLine();

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            Console.WriteLine();

            Console.WriteLine(deck.ToString());

            Console.WriteLine("----- Addtional Tasks -----\n");

            // Addtional Task 1
            hand = deck.Deal5();
            Console.WriteLine(hand.ToString());

            // Addtional Task 2
            hand.HighestCards(hand);
        }
    }
}
