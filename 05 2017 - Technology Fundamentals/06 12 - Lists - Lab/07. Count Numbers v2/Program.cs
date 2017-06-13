using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            var count = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (
                    (i == numbers.Count - 1) ||
                    (i < numbers.Count - 1 && numbers[i] != numbers[i + 1])
                    )
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                    count = 0;
                }
                count++;
            }
        }
    }
}
