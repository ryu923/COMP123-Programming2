using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    // 3. Card Class
    public class Card : ICloneable
    {
        // FIELDS(PRIVATE INSTANCE VARIABLE)
        private Face _face;
        private Suit _suit;

        // PROPERTIES
        //public Face Face { get; set; }
        //public Suit Suit { get; set; }
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }

        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }

        // CONSTRUCTOR
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        // METHODS
        // [Clone()] method sould be put into code because of [ICloneable]
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }

        public static void Overwrite(Card first, Card second)
        {
            first.Face = second.Face;
            first.Suit = second.Suit;
        }
    }
}
