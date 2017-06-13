using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count == 1 || i == numbers.Count - 1) break;

                if(numbers[i] == numbers[i+1])
                {
                    numbers[i] *= 2;
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
