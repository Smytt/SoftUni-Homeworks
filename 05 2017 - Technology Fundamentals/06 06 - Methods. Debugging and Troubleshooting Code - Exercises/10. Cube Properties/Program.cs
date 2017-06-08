using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            var cubeProperty = Console.ReadLine();

            Console.WriteLine($"{CalculateCubeProperty(side, cubeProperty):f2}");
        }

        static double CalculateCubeProperty(double side, string cubeProperty)
        {

            switch(cubeProperty.ToLower())
            {
                case "face": return Math.Sqrt(2 * side * side);
                case "space": return Math.Sqrt(3 * side * side);
                case "volume": return Math.Pow(side, 3);
                case "area": return 6 * side * side;
                default: return 0.0;
            }

        }
    }
}
