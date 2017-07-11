using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while(command[0] != "Odd" && command[0] != "Even")
            {
                if(command[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split(' ').ToList();
            }

            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0) evenNums.Add(num);
                else oddNums.Add(num);
            }

            if (command[0] == "Odd") Console.WriteLine(string.Join(" ", oddNums));
            else Console.WriteLine(string.Join(" ", evenNums));

        }
    }
}
