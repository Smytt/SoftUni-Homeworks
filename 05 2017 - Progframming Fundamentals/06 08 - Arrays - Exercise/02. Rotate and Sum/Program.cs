using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    sum[i] += sequence[(i - j % sequence.Length + sequence.Length) % sequence.Length];
                }
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
