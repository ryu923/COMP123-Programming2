using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Modified
{
    class Rectangle
    {
        // These type of data members are called fields.
        // Notice the access level is restricted to private.
        private int length;
        private int width;

        // Constructors have the same name as the class.
        // Define like methods but no return type is specified.
        // It is called immediately after the object is created
        // It is a good place to put code to make your object useful
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        //Classes may contain action members also called methods.
        public int GetArea()
        {
            return length * width;
        }

        //This method is called when you need to print an object.
        //Very useful when developing code.
        public override string ToString()
        {
            return string.Format("Length:{0}, width:{1}", length, width);
        }
    }
}
