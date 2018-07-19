using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    // 5. Deck Class
    public class Deck : CardList
    {
        // FIELDS(PRIVATE INSTANCE VARIABLES)
        private Random _random;

        // (PRIVATE) PROPERTIES
        //private Random Random { get; } - This is not allowed!
        private Random Random
        {
            get
            {
                return _random;
            }
        }

        // METHOD
        protected override void _initialize()
        {
            this._random = new Random();

            for(int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for(int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        public override string ToString()
        {
            string outputString = "";

            outputString += "Deck Contains Number of Cards: " + this.Count + "\n";
            outputString += "====================================\n";

            foreach(Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        public void Shuffle()
        {
            int firstCard;
            int secondCard;

            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, this.Count);
                secondCard = this.Random.Next(0, this.Count);

                tempCard = (Card)this[secondCard].Clone();

                Card.Overwrite(this[secondCard], this[firstCard]);
                Card.Overwrite(this[firstCard], tempCard);
            }
        }

        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0);

            Console.WriteLine("Dealt 1 card = Size of deck: " + this.Count);

            return topCard;
        }

        // Additional Task1
        public Hand Deal5()
        {
            Hand topFiveCards = new Hand();

            for(int cards = 0; cards < 5; cards++)
            {
                Card pickedCard = this[0];
                topFiveCards.Add(this[0]);
                this.RemoveAt(0);
            }

            return topFiveCards;
        }
    }
}
