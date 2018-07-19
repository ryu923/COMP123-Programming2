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
            // Declare the Variable
            Rectangle bigRect;
            Rectangle smallRect;

            // Allocate storage
            bigRect = new Rectangle();
            smallRect = new Rectangle();

            // Assign to bigRect length variables
            bigRect.length = 8;
            bigRect.width = 5;

            smallRect.length = 3;
            smallRect.width = 2;


            // Display
            Console.WriteLine("[Rectangles Information ]");
            Console.Write("Big Rectangle: ");
            DescribeRectangle(bigRect);
            Console.Write("Small Rectangle: ");
            DescribeRectangle(smallRect);

            Console.WriteLine("\n[Calculate Area of Rectangles]");
            Console.Write("Big Rectangle Area: ");
            CalculateAndDisplayAreaOfRectangle(bigRect);
            Console.Write("Small Rectangle Area: ");
            CalculateAndDisplayAreaOfRectangle(smallRect);

            Console.WriteLine("\n[Create New Rectangle]");
            Console.Write("New Retangle 1: ");
            DescribeRectangle(CreateRectangle(10, 5));
            Console.Write("New Retangle 2: ");
            DescribeRectangle(CreateRectangle(20, 10));
        }

        public static void DescribeRectangle(Rectangle rect)
        {
            Console.WriteLine("Length: {0}, Width: {1}", rect.length, rect.width);
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
