using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(' ');

            Console.WriteLine(String.Join(", ", ArrayActions(sequence)));
        }

        private static string[] ArrayActions(string[] sequence)
        {
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "END")
            {
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
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= sequence.Length)
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine().Split(' ');
                        continue;
                    }                        

                    sequence[int.Parse(command[1])] = command[2];
                }

                else Console.WriteLine("Invalid input!");

                command = Console.ReadLine().Split(' ');
            }

            return sequence;
        }
    }

}
