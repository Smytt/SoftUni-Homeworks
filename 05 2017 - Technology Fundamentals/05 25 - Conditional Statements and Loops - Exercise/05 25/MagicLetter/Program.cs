using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());
            var first = true;

            for (char i = start; i<= end; i++)
            {
                if ( i != skip )
                {
                    for (char j = start; j <= end; j++)
                    {
                        if (j != skip)
                        {
                            for (char k = start; k <= end; k++)
                            {
                                if (k != skip)
                                {
                                    if (first)
                                    {
                                        Console.Write($"{i}{j}{k}");
                                        first = false;
                                    }
                                    else
                                    {
                                        Console.Write($" {i}{j}{k}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
