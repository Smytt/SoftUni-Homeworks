using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            var lastCombination = "";
            var found = false;

            for ( int i = n; i<=m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    if (i + j == magic)
                    {
                        found = true;
                        lastCombination = $"Number found! {i} + {j} = {magic}";
                    }
                }
            }

            if (found)
            {
                Console.WriteLine(lastCombination);
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
