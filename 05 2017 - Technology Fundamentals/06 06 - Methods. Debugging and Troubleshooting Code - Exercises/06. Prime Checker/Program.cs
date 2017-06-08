using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(n));
        }

        static bool isPrime(long n)
        {
            if (n == 0 || n == 1) return false;
            if (n == 2 || n == 3) return true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
