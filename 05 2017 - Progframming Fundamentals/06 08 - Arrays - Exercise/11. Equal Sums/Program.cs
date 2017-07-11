using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence =
                Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();
            bool isFound = false;

            for (int i = 0; i < sequence.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i-1; j >= 0; j--)
                {
                    leftSum += sequence[j];
                }

                for (int j = i + 1; j < sequence.Length; j++)
                {
                    rightSum += sequence[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound) Console.WriteLine("no");
        }
    }
}
