using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var textOfInterest = Console.ReadLine().ToLower();
            var isFound = false;
            var counter = 0;
            var currentIndex = -1;

            do
            {
                isFound = false;
                currentIndex = input.IndexOf(textOfInterest, currentIndex + 1);

                if (currentIndex == -1) continue;
                else
                {
                    counter++;
                    isFound = true;
                }

            }
            while (isFound == true);

            Console.WriteLine(counter);
        }
    }
}
