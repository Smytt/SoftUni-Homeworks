using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) != (int)Math.Sqrt(numbers[i]))
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            numbers.Sort();
            numbers.Reverse();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
