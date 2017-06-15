using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add": CommandAdd(numbers, command); break;
                    case "addMany": CommandAddMany(numbers, command); break;
                    case "contains": CommandContains(numbers, command); break;
                    case "remove": CommandRemove(numbers, command); break;
                    case "shift": CommandShift(numbers, command); break;
                    case "sumPairs": CommandSumPairs(numbers, command); break;
                    default: break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine("[" + String.Join(", ", numbers) + "]");
        }

        static void CommandSumPairs(List<int> numbers, List<string> command)
        {
            List<int> pairs = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i!=numbers.Count-1)
                {
                    numbers[i]+=numbers[i+1];
                    numbers.RemoveAt(i + 1);
                }
            }
        }

        static List<int> CommandShift(List<int> numbers, List<string> command)
        {
            for (int i = 0; i < int.Parse(command[1]); i++)
            {
                int temp = numbers[0];
                for (int j = 0; j < numbers.Count; j++)
                {                    
                    if (j == numbers.Count - 1) numbers[j] = temp;
                    else numbers[j] = numbers[j + 1];
                }
            }
            return numbers;
        }

        static List<int> CommandRemove(List<int> numbers, List<string> command)
        {
            numbers.RemoveAt(int.Parse(command[1]));
            return numbers;
        }

        static void CommandContains(List<int> numbers, List<string> command)
        {
            try
            {
                Console.WriteLine(numbers.IndexOf(int.Parse(command[1])));
            }
            catch (Exception)
            {
                Console.WriteLine(-1);
            }
        }

        static List<int> CommandAddMany(List<int> numbers, List<string> command)
        {
            for (int i = command.Count - 1; i > 1; i--)
            {
                numbers.Insert(int.Parse(command[1]), int.Parse(command[i]));
            }
            return numbers;
        }

        static List<int> CommandAdd(List<int> numbers, List<string> command)
        {
            numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
            return numbers;
        }
    }
}
