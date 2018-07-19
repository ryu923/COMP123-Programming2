using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Q1A. BadRectangle: Create smallRectangle Object]");
            BadRectangle smallBadRectangle = CreateBadRectangle(4, 5);

            Console.WriteLine("\n[Q2A. BadRectangle: Describe smallRectangle Object]");
            DescribeBadRectangle(smallBadRectangle);

            Console.WriteLine("\n[Q3A. BadRectangle: Calculate The Area of smallRectangle and Display]");
            CalculateAndDisplayArea(smallBadRectangle);

            Console.WriteLine("\n[Q1B. Rectangle: Create smallRectangle Object]");
            Rectangle smallRectangle = new Rectangle(4, 5);

            Console.WriteLine("\n[Q2B. Rectangle: Describe smallRectangle Object]");
            Console.WriteLine(smallRectangle.ToString());

            Console.WriteLine("\n[Q3B. Rectangle: Calculate The Area of smallRectangle and Display]");
            Console.WriteLine("Area: " + smallRectangle.GetArea());
        }

        public static BadRectangle CreateBadRectangle(int width, int length)
        {
            BadRectangle badRectangle = new BadRectangle();
            badRectangle.width = width;
            badRectangle.length = length;

            return badRectangle;
        }

        public static void DescribeBadRectangle(BadRectangle br)
        {
            Console.WriteLine("Width: {0}, Length: {1}", br.width, br.length);
        }

        public static void CalculateAndDisplayArea(BadRectangle br)
        {
            int area = br.width * br.length;

            Console.WriteLine("Area: {0}", area);
        }
    }
}
