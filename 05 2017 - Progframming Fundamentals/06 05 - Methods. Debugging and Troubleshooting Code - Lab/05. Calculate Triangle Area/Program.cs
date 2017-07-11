using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(a, h));
        }

        static double TriangleArea(double a, double h)
        {
            double result = a * h / 2;
            return result;
        }
    }
}
