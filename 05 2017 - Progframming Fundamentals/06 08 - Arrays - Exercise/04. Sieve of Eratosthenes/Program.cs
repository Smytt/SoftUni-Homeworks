using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] allNumbers = new bool[n + 1];
            for (int i = 2; i < allNumbers.Length; i++)
            {
                allNumbers[i] = true;
            }

            for (int i = 0; i < allNumbers.Length; i++)
            {
                if (allNumbers[i] == true)
                {
                    for (int k = 2; k * i < allNumbers.Length; k++)
                    {
                        allNumbers[i * k] = false;
                    }
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
