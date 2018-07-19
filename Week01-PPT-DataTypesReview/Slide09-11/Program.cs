using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide09_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle bigRect;
            bigRect = new Rectangle();
            bigRect.length = 8;
            bigRect.width = 5;

            Rectangle smallRect = new Rectangle();
            smallRect.length = 3;
            smallRect.width = 2;

            // Add Codes for Display
            Console.WriteLine("[Big Rectangle]");
            DescribeRectangle(bigRect);
            CalculateAndDisplayAreaOfRectangle(bigRect);

            Console.WriteLine("\n[Small Rectangle]");
            DescribeRectangle(smallRect);
            CalculateAndDisplayAreaOfRectangle(smallRect);

            Console.WriteLine("\n[New Rectangle]");
            CreateRectangle(10, 10);
            DescribeRectangle(CreateRectangle(10, 10));
            CalculateAndDisplayAreaOfRectangle(CreateRectangle(10, 10));
        }

        public static void DescribeRectangle(Rectangle rect)
        {
            Console.WriteLine("Width: {0}, Length: {1}", rect.width, rect.length);
        }

        public static void CalculateAndDisplayAreaOfRectangle(Rectangle rect)
        {
            int area = rect.width * rect.length;
            Console.WriteLine("Area: {0}", area);
        }

        public static Rectangle CreateRectangle(int width, int length)
        {
            Rectangle rect = new Rectangle();

            rect.width = width;
            rect.length = length;

            return rect;
        }
    }
}
