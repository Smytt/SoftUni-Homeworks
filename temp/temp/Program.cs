using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int currentIndex = 0;
            int bestIndex = 0;
            int bestcount = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[currentIndex])
                {
                    count++;
                    if (count > bestcount)
                    {
                        bestcount = count;
                        bestIndex = currentIndex;
                    }

                }
                else
                {
                    count--;
                }
                if (count == 0)
                {
                    currentIndex = i;
                    count = 1;
                }
            }

            int mostFreq = arr[bestIndex];
            Console.WriteLine(mostFreq);
        }
    }
}