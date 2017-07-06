using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var msgPattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$";

            var inputMsg = Console.ReadLine();

            while (inputMsg != "Over!")
            {
                var number = int.Parse(Console.ReadLine());

                var match = Regex.Match(inputMsg, msgPattern);
                if (!match.Success || match.Groups[2].Length != number)
                {
                    inputMsg = Console.ReadLine();
                    continue;
                }

                var msg = match.Groups[2].Value;

                var validationIndexesLeft = match.Groups[1].Value
                    .ToCharArray()
                    .Select(x => int.Parse(x.ToString()))
                    .ToArray();
                var validationIndexesRight = match.Groups[3].Value
                    .ToCharArray()
                    .Where(x => Regex.Match(x.ToString(), @"[0-9]").Success)
                    .Select(x => int.Parse(x.ToString()))
                    .ToArray();
                var validationIndexes = validationIndexesLeft.Concat(validationIndexesRight).ToArray();

                var validationMsg = new StringBuilder();

                foreach (var index in validationIndexes)
                {
                    if (index > msg.Length - 1)
                    {
                        validationMsg.Append(" ");
                        continue;
                    }
                    validationMsg.Append(msg[index]);
                }

                Console.WriteLine($"{msg} == {validationMsg}");
                inputMsg = Console.ReadLine();
            }
        }
    }
}
