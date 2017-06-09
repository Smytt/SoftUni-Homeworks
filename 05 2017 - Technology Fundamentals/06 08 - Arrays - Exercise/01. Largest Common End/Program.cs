using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            Console.WriteLine(LargestCommonEnd(array1, array2));
        }

        static int LargestCommonEnd(string[] array1, string[] array2)
        {
            int largestCommonEndLeft = 0;
            bool leftDiffers = false;
            int largestCommonEndRight = 0;
            bool rightDiffers = false;
            int shortLength = Math.Min(array1.Length, array2.Length);

            for (int i = 0; i < shortLength; i++)
            {
                if (!leftDiffers && array1[i] == array2[i])
                {
                    largestCommonEndLeft++;
                }
                else leftDiffers = true;

                if (!rightDiffers && array1[array1.Length - 1 -i] == array2[array2.Length - 1 - i])
                {
                    largestCommonEndRight++;
                }
                else rightDiffers = true;

                if (leftDiffers && rightDiffers) break;
            }

            return Math.Max(largestCommonEndLeft, largestCommonEndRight);

        }
    }
}
