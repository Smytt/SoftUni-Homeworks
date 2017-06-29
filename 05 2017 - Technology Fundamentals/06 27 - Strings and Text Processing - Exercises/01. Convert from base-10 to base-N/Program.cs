using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            var newBase = input[0];
            BigInteger number = input[1];

            var result = new StringBuilder();

            while (number > 0)
            {
                var digit = number % newBase;
                number = (number / newBase);

                result.Insert(0,digit);
            }

            Console.WriteLine(result);
        }
    }
}
