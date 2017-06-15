using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.a.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double f = double.Parse(Console.ReadLine());

            Console.WriteLine($"{FahrenheitToCelsius(f):f2}");
        }

        static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
