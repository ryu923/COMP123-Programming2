using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        // FIELDS
        private int length;
        private int width;

        // CONSTRUCTOR
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        // METHOD
        public int GetArea()
        {
            return length * width;
        }

        // ToString() Method
        public override string ToString()
        {
            return string.Format("Length: {0}, Width: {1}", length, width);
        }
    }
}
