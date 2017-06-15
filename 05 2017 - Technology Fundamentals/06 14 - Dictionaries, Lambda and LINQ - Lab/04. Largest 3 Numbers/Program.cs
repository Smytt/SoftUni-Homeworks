using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> largestThree =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(x => -x)
                .Take(3)
                .ToList();

            Console.WriteLine(String.Join(" ", largestThree));
        }
    }
}
