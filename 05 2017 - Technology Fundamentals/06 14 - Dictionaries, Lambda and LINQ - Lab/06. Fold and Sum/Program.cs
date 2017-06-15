using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;

            int[] firstQ = numbers.Take(k).Reverse().ToArray();
            int[] fourthQ = numbers.Reverse().Take(k).ToArray();
            int[] topHalf = firstQ.Concat(fourthQ).ToArray();
            int[] bottomHalf = numbers.Skip(k).Take(2 * k).ToArray();

            int[] sum = topHalf.Select((x, index) => x + bottomHalf[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
