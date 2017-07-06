using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new int[int.Parse(Console.ReadLine())];
            var ladybugsIndexes = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            for (int i = 0; i < field.Length; i++)
            {
                if (ladybugsIndexes.Any(x => x == i)) field[i] = 1;
                else field[i] = 0;
            }

            var command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                var startIndex = int.Parse(command[0]);
                var direction = -1;
                if (command[1] == "right") direction = 1;
                var places = int.Parse(command[2]);

                if (startIndex > field.Length -1 || startIndex < 0 || field[startIndex] == 0)
                {
                    command = Console.ReadLine().Split().ToList();
                    continue;
                }

                field[startIndex] = 0;
                var canLand = false;
                var tryAgain = 1;

                while (!canLand)
                {
                    var newIndex = (long)places * tryAgain * direction + startIndex;

                    if (newIndex > field.Length - 1 || newIndex < 0) break;

                    if (field[newIndex] == 1)
                    {
                        tryAgain++;
                        continue;
                    }
                    else
                    {
                        field[newIndex] = 1;
                        canLand = true;
                    }
                }

                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
