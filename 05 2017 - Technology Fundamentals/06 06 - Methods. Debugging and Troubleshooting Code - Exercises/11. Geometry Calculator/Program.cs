using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            double parameter1 = double.Parse(Console.ReadLine());


            switch (figure)
            {
                case "triangle":
                    {
                        double parameter2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{Triangle(parameter1, parameter2):f2}");
                    }
                    break;
                case "square": Console.WriteLine($"{Square(parameter1):f2}"); break;
                case "rectangle":
                    {
                        double parameter2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{Rectangle(parameter1, parameter2):f2}");
                    }
                    break;
                case "circle": Console.WriteLine($"{Circle(parameter1):f2}"); break;
            }
        }

        static double Circle(double parameter1)
        {
            return parameter1 * parameter1 * Math.PI;
        }

        static double Rectangle(double parameter1, double parameter2)
        {
            return parameter1 * parameter2;
        }

        static double Square(double parameter1)
        {
            return parameter1 * parameter1;
        }

        static double Triangle(double parameter1, double parameter2)
        {
            return parameter1 * parameter2 / 2;
        }
    }
}
