using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var count = 0;
            var bestCount = 0;
            var bestIndex = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                count++;

                if ((i < numbers.Count - 1 && numbers[i] != numbers[i + 1])
                    || i == numbers.Count - 1)
                {
                    if (bestCount < count)
                    {
                        bestCount = count;
                        bestIndex = i;
                    }
                    count = 0;
                }
            }

            for (int i = bestIndex - bestCount + 1; i <= bestIndex; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
