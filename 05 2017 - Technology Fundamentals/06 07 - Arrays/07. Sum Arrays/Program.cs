using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int max = Math.Max(array1.Length, array2.Length);
            int[] sum = new int[max];

            for (int i = 0; i < max; i++)
            {
                sum[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
