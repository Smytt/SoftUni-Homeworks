using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence =
                Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < sequence.Length-1; i++)
            {
                for (int j = i+1; j < sequence.Length; j++)
                {
                    if (Math.Abs(sequence[i] - sequence[j]) == diff) count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
