using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double mp = w * h / 1000000;
            Console.WriteLine($"{w}x{h} => {Math.Round(mp,1)}MP");
        }
    }
}
