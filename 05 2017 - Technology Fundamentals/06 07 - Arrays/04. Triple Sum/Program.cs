using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = 
                Console.ReadLine()
                .Trim().Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            bool contains = false;

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = i+1; j < sequence.Length ; j++)
                {
                    if(sequence.Contains(sequence[i] + sequence[j]))
                    {
                        Console.WriteLine($"{sequence[i]} + {sequence[j]} == {sequence[i] + sequence[j]}");
                        contains = true;
                    }
                }
            }

            if (!contains) Console.WriteLine("No");        
        }
    }
}
