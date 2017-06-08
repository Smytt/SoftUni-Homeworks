using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));

        }

        static int Fib(int n)
        {
            if ( n ==0 || n == 1)
            {
                return 1;
            }

            int a = 0;
            int b = 1;

            for ( int i = 0; i<=n; i++)
            {
                int number = a + b;
                b = a;
                a = number;
            }

            return a;
        }
    }
}
