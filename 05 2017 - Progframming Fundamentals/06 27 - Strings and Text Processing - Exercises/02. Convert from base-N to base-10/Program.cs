using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var oldBase = int.Parse(input[0]);
            var number = input[1];
            BigInteger baseTen = 0;

            var result = new StringBuilder();

            for (int i = 0; i < number.Length; i++)
            {
                baseTen += Convert.ToInt32(new String(number[i], 1)) * BigInteger.Pow(oldBase, number.Length - 1 - i);
            }

            Console.WriteLine(baseTen);
        }
    }
}
