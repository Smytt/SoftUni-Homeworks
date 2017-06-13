using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
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

            int counter = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count == 1)
                {
                    Console.WriteLine($"{numbers[0]} -> {1}");
                    break;
                }

                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (i == numbers.Count - 2)
                    {
                        Console.WriteLine($"{numbers[i]} -> {counter}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {counter}");
                    counter = 1;
                    if (i == numbers.Count - 2)
                    {
                        Console.WriteLine($"{numbers[i+1]} -> {counter}");
                        break;
                    }
                }
            }
        }
    }
}
