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
            long x1 = long.Parse(Console.ReadLine());
            long y1 = long.Parse(Console.ReadLine());
            long x2 = long.Parse(Console.ReadLine());
            long y2 = long.Parse(Console.ReadLine());

            Console.WriteLine(CloserToCenter(x1, y1, x2, y2));
        }

        static string CloserToCenter(long x1, long y1, long x2, long y2)
        {
            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (distance2 < distance1)
            {
                return $"({x2}, {y2})";
            }
            return $"({x1}, {y1})";
        }
    }
}
