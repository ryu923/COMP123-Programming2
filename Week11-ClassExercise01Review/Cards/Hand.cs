﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    // 6. Hand Class
    public class Hand : CardList
    {
        // METHODS
        protected override void _initialize()
        {
           
        }

        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand Contains Number of Cards: " + this.Count + "\n";
            outputString += "====================================\n";

            foreach(Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        // Additional Task2
        public void HighestCards(Hand hand)
        {
            var sortHandCards =
                from cards in hand
                orderby cards.Face descending, cards.Suit descending
                select cards;

            int number = 0;
            int highest = 0;

            foreach(Card cards in sortHandCards)
            {
                if(number == 0)
                {
                    highest = (int)cards.Face;
                }
                else
                {
                    if ((int)cards.Face < highest)
                        break;
                }

                string message = "";
                message += "The highest card is: " + cards.Face + " of " + cards.Suit;
                Console.WriteLine(message);

                number++;
            }
        }
    }
}
