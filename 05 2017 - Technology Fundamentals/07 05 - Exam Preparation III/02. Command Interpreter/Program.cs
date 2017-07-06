using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Regex.Split(Console.ReadLine(), @" +").Where(x => x != "").ToArray();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var command = input.Split().ToList();

                if (CommandIsInvalid(command, arr))
                {
                    Console.WriteLine($"Invalid input parameters.");
                    input = Console.ReadLine();
                    continue;
                }

                if (command[0] == "reverse") arr = ReverseCollection(int.Parse(command[2]), int.Parse(command[4]), arr);
                if (command[0] == "sort") arr = SortCollection(int.Parse(command[2]), int.Parse(command[4]), arr);
                if (command[0] == "rollLeft") arr = RollLeftCollection(long.Parse(command[1]), arr);
                if (command[0] == "rollRight") arr = RollRightCollection(long.Parse(command[1]), arr);

                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        private static string[] RollRightCollection(long count, string[] arr)
        {
            var portion = arr
                .Take(arr.Length - (int)(count % arr.Length))
                .ToArray();
            var resultArr = arr
                .Skip(arr.Length - (int)(count % arr.Length))
                .Concat(portion)
                .ToArray();
            return resultArr;
        }

        private static string[] RollLeftCollection(long count, string[] arr)
        {
            var portion = arr
                .Take((int)(count % arr.Length))
                .ToArray();
            var resultArr = arr
                .Skip((int)(count % arr.Length))
                .Concat(portion)
                .ToArray();
            return resultArr;
        }

        private static string[] SortCollection(int start, int count, string[] arr)
        {

            var portion = arr
                .Skip(start)
                .Take(count)
                .OrderBy(x => x)
                .ToArray();
            var resultArr = arr
                .Take(start)
                .Concat(portion)
                .Concat(arr.Skip(start + count))
                .ToArray();
            return resultArr;
        }

        private static string[] ReverseCollection(int start, int count, string[] arr)
        {
            var portion = arr
                .Skip(start)
                .Take(count)
                .Reverse()
                .ToArray();
            var resultArr = arr
                .Take(start)
                .Concat(portion)
                .Concat(arr.Skip(start + count))
                .ToArray();
            return resultArr;
        }

        private static bool CommandIsInvalid(List<string> command, string[] arr)
        {
            if (command[0] == "reverse" || command[0] == "sort")
            {
                if (long.Parse(command[4]) < 0) return true;
                if (long.Parse(command[2]) < 0 || long.Parse(command[2]) > arr.Length - 1) return true;
                if (long.Parse(command[2]) + long.Parse(command[4]) - 1 > arr.Length - 1) return true;
            }
            if (command[0] == "rollLeft" || command[0] == "rollRight")
            {
                if (long.Parse(command[1]) < 0) return true;
            }
            return false;
        }
    }
}
