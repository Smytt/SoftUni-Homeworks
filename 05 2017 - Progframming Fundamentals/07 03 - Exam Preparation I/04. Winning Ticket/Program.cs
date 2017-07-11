using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Regex.Split(Console.ReadLine(), @"\s*,\s*").Select(x => x.Trim()).Where(x => x != "").ToList();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftSide = ticket.Substring(0, 10);
                var rightSide = ticket.Substring(10);
                var matchLeft = Regex.Match(leftSide, @"([\^\$\#@])(\1{5,9})");
                var matchRight = Regex.Match(rightSide, @"([\^\$\#@])(\1{5,9})");

                if (matchLeft.Length < 6 || matchRight.Length < 6)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }
                if (matchLeft.Length == 10 && matchRight.Length == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{matchLeft.Groups[1]} Jackpot!");
                    continue;
                }
                Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(matchLeft.Groups[2].Length, matchRight.Groups[2].Length) + 1}{matchLeft.Groups[1]}");
            }
        }
    }
}
