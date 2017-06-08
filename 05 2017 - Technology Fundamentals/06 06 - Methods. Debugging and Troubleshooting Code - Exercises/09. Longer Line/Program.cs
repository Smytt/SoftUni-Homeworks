using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            Console.WriteLine(LongerLine(x1, y1, x2, y2, x3, y3, x4, y4));
        }

        static string LongerLine(
            double x1, double y1,
            double x2, double y2,
            double x3, double y3,
            double x4, double y4
            )
        {
            double line1 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
            double line2 = Math.Sqrt(Math.Pow(Math.Abs(x3 - x4), 2) + Math.Pow(Math.Abs(y3 - y4), 2));
            if (line2 > line1)
            {
                return CloserToCenter(x3, y3, x4, y4);
            }
            return CloserToCenter(x1, y1, x2, y2);
        }

        static string CloserToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (distance2 < distance1)
            {
                return $"({x2}, {y2})({x1}, {y1})";
            }
            return $"({x1}, {y1})({x2}, {y2})";
        }
    }
}
