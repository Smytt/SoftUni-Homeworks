using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> bomb = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (numbers.IndexOf(bomb[0]) >= 0)
            {
                var min = Math.Max(0, numbers.IndexOf(bomb[0]) - bomb[1]);
                var max = Math.Min(numbers.Count - 1, numbers.IndexOf(bomb[0]) + bomb[1]);

                for (int i = min; i <= max; i++)
                {
                    numbers.RemoveAt(min);
                }
            }

            int sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
