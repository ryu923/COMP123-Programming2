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
            Console.WriteLine("[Q1. Create smallRectangle]");
            BadRectangle smallRectangle = CreateBadRectangle(5, 4);

            Console.WriteLine("\n[Q2. Describe smallRectangle]");
            DescribeBadRectangle(smallRectangle);

            Console.WriteLine("\n[Q3. Calculate area of smallRectangle and Display]");
            CalculateAndDisplayArea(smallRectangle);
        }

        static BadRectangle CreateBadRectangle(int width, int length)
        {
            BadRectangle rectangle1 = new BadRectangle();
            rectangle1.width = width;
            rectangle1.length = length;

            return rectangle1;
        }

        static void DescribeBadRectangle(BadRectangle rect)
        {
            Console.WriteLine("Width: {0}, Length: {1}", rect.width, rect.length);
        }

        static void CalculateAndDisplayArea(BadRectangle rect)
        {
            int area = rect.width * rect.length;

            Console.WriteLine("Area: {0}", area);
        }
    }
}
