using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] reversed = new int[n];

            for (int i = 1; i <= n; i++)
            {
                reversed[n - i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}
