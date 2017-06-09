using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sequence = 
                Console.ReadLine()
                .Trim().Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (var i in sequence)
            {
                Console.WriteLine($"{i} => {Math.Round(i, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
