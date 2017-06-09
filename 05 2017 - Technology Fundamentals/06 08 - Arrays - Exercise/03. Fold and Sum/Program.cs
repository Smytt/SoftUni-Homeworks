using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] sum = new int[k*2];

            for (int i = 0; i < k; i++)
            {
                sum[i] = numbers[k + i] + numbers[k - 1 - i];
                sum[k * 2 - 1 - i] = numbers[3 * k + i] + numbers[3 * k - 1 - i];
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
