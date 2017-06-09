using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices =
                Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();
            int gold = 0;
            int jewels = 0;
            int expenses = 0;

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "Jail" && command[1] != "Time")
            {
                for (int i = 0; i < command[0].Length; i++)
                {
                    if ((command[0])[i] == '%') jewels++;
                    else if ((command[0])[i] == '$') gold++;
                }
                expenses += int.Parse(command[1]);
                command = Console.ReadLine().Split(' ');
            }

            int earning = jewels * prices[0] + gold * prices[1];

            if (earning >= expenses)
                Console.WriteLine($"Heists will continue. Total earnings: {earning - expenses}.");
            else Console.WriteLine($"Have to find another job. Lost: {expenses - earning}.");
        }
    }
}
