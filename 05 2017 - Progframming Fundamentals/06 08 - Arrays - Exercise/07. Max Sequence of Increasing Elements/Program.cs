using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestCount = 0;
            int startIndex = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                int j = i;
                int currentCount = 1;

                while (j < sequence.Length - 1 && sequence[j + 1] > sequence[j])
                {
                    j++;
                    currentCount++;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    startIndex = i;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{sequence[startIndex + i]} ");
            }
        }
    }
}
