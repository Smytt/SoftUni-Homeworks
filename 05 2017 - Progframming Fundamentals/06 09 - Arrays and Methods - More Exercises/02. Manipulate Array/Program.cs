using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(", ", ArrayActions(sequence, n)));
        }

        private static string[] ArrayActions(string[] sequence, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Reverse")
                {
                    Array.Reverse(sequence);
                }

                else if (command[0] == "Distinct")
                {
                    sequence = sequence.Distinct().ToArray();
                }

                else if (command[0] == "Replace")
                {
                    sequence[int.Parse(command[1])] = command[2];
                }
            }

            return sequence;
        }
    }
}
