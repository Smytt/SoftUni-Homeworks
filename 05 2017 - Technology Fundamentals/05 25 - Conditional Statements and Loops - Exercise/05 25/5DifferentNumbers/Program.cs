using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if (end - start < 4)
            {
                Console.WriteLine("No");
            }

            else
            {
                for (int i = start; i <= end - 4; i++)
                {
                    for (int j = i + 1; j <= end - 3; j++)
                    {
                        for (int k = j + 1; k <= end - 2; k++)
                        {
                            for (int l = k + 1; l <= end - 1; l++)
                            {
                                for (int m = l + 1; m <= end; m++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
