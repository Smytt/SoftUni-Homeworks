using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = '0';
            string dna = "0ACGT";
            int count = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        count++;
                        if (i + j + k >= n) symbol = 'O';
                        else symbol = 'X';
                        Console.Write($"{symbol}{dna[i]}{dna[j]}{dna[k]}{symbol} ");

                        if (count == 4)
                        {
                            count = 0;
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
