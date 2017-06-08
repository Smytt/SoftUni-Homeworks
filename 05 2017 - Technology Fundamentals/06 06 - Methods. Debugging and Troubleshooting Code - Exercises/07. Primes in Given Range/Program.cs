using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            PrintList(PrimesInRange(start, end));
        }

        static void PrintList(List<int> list)
        {
            bool isFirst = true;
            list.ForEach(x =>
                {
                    if (isFirst) Console.Write($"{x}");
                    else Console.Write($", {x}");
                    isFirst = false;
                }
            );
            Console.WriteLine();
        }
        static List<int> PrimesInRange(int start, int end)
        {
            List<int> primesInRange = new List<int>();
            bool isPrime = true;
            for (int n = start; n <= end; n++)
            {
                if (n == 2 || n == 3)
                {
                    primesInRange.Add(n);
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                            isPrime = false;
                    }
                    if (isPrime) primesInRange.Add(n);
                    isPrime = true;
                }
            }
            return primesInRange;
        }
    }
}
