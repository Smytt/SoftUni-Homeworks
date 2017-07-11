using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = ReadRectangle();
            Rectangle rectangle2 = ReadRectangle();

            bool isInside = checkRectangles(rectangle1, rectangle2);

            if (isInside) Console.WriteLine("Inside");
            else Console.WriteLine("Not Inside");
        }

        static bool checkRectangles(Rectangle rectangle1, Rectangle rectangle2)
        {
            var inLeft = rectangle1.left >= rectangle2.left;
            var inRight = rectangle1.right <= rectangle2.right;
            var inTop = rectangle1.top >= rectangle2.top;
            var inBottom = rectangle1.bottom <= rectangle2.bottom;

            if (inLeft && inRight && inTop && inBottom) return true;
            return false;
        }

        static Rectangle ReadRectangle()
        {
            Rectangle rectangle = new Rectangle();
            var command = Console.ReadLine().Split().Select(int.Parse).ToList();
            rectangle.left = command[0];
            rectangle.top = command[1];
            rectangle.width = command[2];
            rectangle.height = command[3];
            return rectangle;
        }
    }

    class Rectangle
    {
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int right { get { return left + width; } }
        public int bottom { get { return top + height; } }
    }
}
