using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = ReadPoint();
            Point b = ReadPoint();

            double distance = calculateDistance(a, b);

            Console.WriteLine($"Distance: {distance:f3}");
        }

        private static Point ReadPoint()
        {
            var coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.x = coordinates[0];
            point.y = coordinates[1];

            return point; 
        }

        static double calculateDistance(Point a, Point b)
        {
            var line1 = Math.Abs(a.x - b.x);
            var line2 = Math.Abs(a.y - b.y);
            var distance = Math.Sqrt(line1 * line1 + line2 * line2);
            return distance;
        }
    }

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
