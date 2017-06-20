using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var filterEvens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToList();

            var result = filterEvens.Select(x => x < filterEvens.Average() ? x-1 : x+1).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
