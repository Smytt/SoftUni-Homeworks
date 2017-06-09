using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            ArrayProperties(sequence);
        }

        static void ArrayProperties(int[] sequence)
        {
            int max = sequence[0];
            int min = sequence[0];
            int sum = sequence[0];

            for (int i = 1; i < sequence.Length; i++)
            {
                max = Math.Max(max, sequence[i]);
                min = Math.Min(min, sequence[i]);
                sum += sequence[i];
            }

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {(double)sum/sequence.Length}");
        }
    }
}
