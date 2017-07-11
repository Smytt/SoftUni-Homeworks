using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            double minDistance = double.MaxValue;
            Point shortestLineA = new Point();
            Point shortestLineB = new Point();

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if(calculateDistance(points[i], points[j]) < minDistance)
                    {
                        minDistance = calculateDistance(points[i], points[j]);
                        shortestLineA = points[i];
                        shortestLineB = points[j];
                    }
                    minDistance = Math.Min(calculateDistance(points[i], points[j]), minDistance);
                }
            }

            Console.WriteLine("{0:f3}", minDistance);
            Console.WriteLine("({0}, {1})", shortestLineA.x, shortestLineA.y);
            Console.WriteLine("({0}, {1})", shortestLineB.x, shortestLineB.y);

        }

        private static double calculateDistance(Point point1, Point point2)
        {
            var line1 = Math.Abs(point1.x - point2.x);
            var line2 = Math.Abs(point1.y - point2.y);
            var distance = Math.Sqrt(line1 * line1 + line2 * line2);
            return distance;
        }

        static Point ReadPoint()
        {
            var point = new Point();
            var coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            point.x = coordinates[0];
            point.y = coordinates[1];
            return point;
        }
    }

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
