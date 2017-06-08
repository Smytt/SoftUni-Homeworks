using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(TrailingZerosOfFactorial(n));
        }

        static int TrailingZerosOfFactorial(int n)
        {
            int zeros = 0;

            for (int i = 1; i <= n; i++)
            {
                int j = i;

                while (j >= 10 && j % 10 == 0)
                {
                    j /= 10;
                    zeros++;
                }

                while (j >= 5 && j % 5 == 0)
                {
                    j /= 5;
                    zeros++;
                }
            }

            return zeros;
        }
    }
}
