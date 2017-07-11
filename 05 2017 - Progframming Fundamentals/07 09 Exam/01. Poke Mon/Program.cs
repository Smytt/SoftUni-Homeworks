using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            decimal exhaust = (decimal)start / 2;
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            long hits = 0;

            long n = start;

            if (n == exhaust)
            {
                try
                {
                    n /= y;
                }
                catch
                {

                }
            }

            while (n >= m)
            {
                n -= m;
                hits++;

                if (n == exhaust)
                {
                    try
                    {
                        n /= y;
                    }
                    catch
                    {

                    }
                }
            }


            Console.WriteLine(n);
            Console.WriteLine(hits);

        }
    }
}
