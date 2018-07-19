using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    // 6. Create Deck Class
    public class Deck : CardList
    {
        // FIELDS(PRIVATTE INSTANCE VARIABLES)
        private Random _random;

        // PROPERTIES - Private
        private Random Random
        {
            get
            {
                return _random;
            }
        }

        // METHODS
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

            for(int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, this.Count);
                secondCard = this.Random.Next(0, this.Count);

                tempCard = (Card)this[secondCard].Clone();

                Card.OverWrite(this[secondCard], this[firstCard]);
                Card.OverWrite(this[firstCard], tempCard);
            }
        }

        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0);

            Console.WriteLine("Dealt 1 card - size of deck: " + this.Count);

            return topCard;
        }

        // Addtional Task 1
        public Hand Deal5()
        {
            Hand topFiveHand = new Hand();

            for(int topCards = 0; topCards < 5; topCards++)
            {
                Card topFive = this[0];
                topFiveHand.Add(this[0]);
                this.RemoveAt(0);
            }

            return topFiveHand;
        }
    }
}
