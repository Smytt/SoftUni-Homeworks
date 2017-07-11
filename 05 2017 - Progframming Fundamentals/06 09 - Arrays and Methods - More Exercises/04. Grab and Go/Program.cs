using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());
            long sum = 0;
            int index = 0;
            bool isPresent = false;

            for (int i = 0; i < sequence.Length; i++)
            {                
                if (sequence[i] == number)
                {
                    index = i;
                    isPresent = true;
                }
            }

            if (!isPresent)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }

            for (int i = 0; i < index; i++)
            {
                sum += sequence[i];
            }
            Console.WriteLine(sum);


        }
    }
}
