using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle();
            Circle circle2 = ReadCircle();

            if (DoesIntersect(circle1, circle2)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        private static bool DoesIntersect(Circle circle1, Circle circle2)
        {
            var distance = DistanceBetweenPoints(circle1.center, circle2.center);

            if (distance <= circle1.radius + circle2.radius) return true;
            return false;
        }

        private static double DistanceBetweenPoints(Point center1, Point center2)
        {
            var line1 = Math.Abs(center1.x - center2.x);
            var line2 = Math.Abs(center1.y - center2.y);

            return Math.Sqrt(line1 * line1 + line2 * line2);
        }

        static Circle ReadCircle()
        {
            Circle circle = new Circle();
            Point center = new Point();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            center.x = input[0];
            center.y = input[1];
            circle.center = center;
            circle.radius = input[2];
            return circle;
        }
    }

    internal class Circle
    {
        public Point center { get; set; }
        public double radius { get; set; }
    }

    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }
}
