using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var input = Console.ReadLine();

            while (String.Compare(input, "end") != 0)
            {
                var command = input.Split().ToArray();

                switch (command[0])
                {
                    case "exchange":
                        arr = DoExchange(arr, int.Parse(command[1]));
                        break;
                    case "max":
                    case "min":
                        Console.WriteLine(DoMaxMin(arr, command));
                        break;
                    case "first":
                    case "last":
                        Console.WriteLine(DoFirstLast(arr, command));
                        break;
                    default: break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        private static string DoFirstLast(int[] arr, string[] command)
        {
            var count = int.Parse(command[1]);
            var resultArr = new int[count];
            if (count > arr.Length) return "Invalid count";

            if (command[0] == "first")
            {
                if (command[2] == "odd")
                    resultArr = arr.Where(x => x % 2 != 0).Take(count).ToArray();
                else resultArr = arr.Where(x => x % 2 == 0).Take(count).ToArray();
            }
            else
            {
                if (command[2] == "odd")
                    resultArr = arr.Where(x => x % 2 != 0).Reverse().Take(count).Reverse().ToArray();
                else resultArr = arr.Where(x => x % 2 == 0).Reverse().Take(count).Reverse().Take(count).ToArray();
            }

            return "[" + string.Join(", ", resultArr) + "]";
        }

        private static string DoMaxMin(int[] arr, string[] command)
        {
            var keepIndexes = arr.Select((x, i) => new { x, i }).ToArray();
            var evensMax = keepIndexes.Where(x => x.x % 2 == 0).OrderBy(x => x.x).ThenBy(x => x.i).ToArray();
            var oddsMax = keepIndexes.Where(x => x.x % 2 != 0).OrderBy(x => x.x).ThenBy(x => x.i).ToArray();
            var evensMin = keepIndexes.Where(x => x.x % 2 == 0).OrderBy(x => x.x).ThenByDescending(x => x.i).ToArray();
            var oddsMin = keepIndexes.Where(x => x.x % 2 != 0).OrderBy(x => x.x).ThenByDescending(x => x.i).ToArray();

            if (command[0] == "max")
            {
                if (command[1] == "even")
                {
                    if (evensMax.Length == 0) return "No matches";
                    return evensMax.Last().i.ToString();
                }

                if (oddsMax.Length == 0) return "No matches";
                return oddsMax.Last().i.ToString();
            }
            if (command[1] == "even")
            {
                if (evensMin.Length == 0) return "No matches";
                return evensMin.First().i.ToString();
            }
            if (oddsMin.Length == 0) return "No matches";
            return oddsMin.First().i.ToString();
        }

        private static int[] DoExchange(int[] arr, int v)
        {
            if (v < 0 || v > arr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }
            return arr.Skip(v + 1).Concat(arr.Take(v + 1)).ToArray();
        }
    }
}
