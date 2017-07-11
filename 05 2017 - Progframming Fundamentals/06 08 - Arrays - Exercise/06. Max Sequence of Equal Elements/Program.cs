using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestCount = 0;
            int bestNumber = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                int j = i;
                int currentCount = 1;

                while (j < sequence.Length - 1 && sequence[j + 1] == sequence[i])
                {
                    j++;
                    currentCount++;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestNumber = sequence[i];
                }
            }

            for (int i = 1; i <= bestCount; i++)
            {
                Console.Write($"{bestNumber} ");
            }
        }
    }
}
