using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;

            while (n > 0)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    n--;
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
