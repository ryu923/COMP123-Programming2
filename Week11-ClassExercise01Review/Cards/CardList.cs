using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    // 4. CardList Abstract Class
    public abstract class CardList : List<Card>
    {
        // CONSTRUCTOR
        public CardList()
        {
            this._initialize();
        }

        // METHOD
        protected abstract void _initialize();
    }
}
