using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = Regex.Split(Console.ReadLine(), @", +").ToList();
            var songList = Regex.Split(Console.ReadLine(), @", +").ToList();
            var winners = new Dictionary<string, List<string>>();
            var hasAward = false;

            while (true)
            {
                var command = Regex.Split(Console.ReadLine(), @", +").ToList();
                if (command[0] == "dawn") break;

                if (userList.Contains(command[0]))
                {
                    if (songList.Contains(command[1]))
                    {
                        if (winners.ContainsKey(command[0]))
                        {
                            if (!winners[command[0]].Contains(command[2]))
                            {
                                winners[command[0]].Add(command[2]);
                                hasAward = true;
                            }
                        }
                        else
                        {
                            winners.Add(command[0], new List<string>() { command[2] });
                            hasAward = true;
                        }                
                    }
                }
            }

            if (!hasAward)
            {
                Console.WriteLine("No awards"); return;
            }

            var sortedWinners = winners.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);


            foreach (var winner in sortedWinners)
            {
                Console.WriteLine($"{winner.Key}: {winner.Value.Count} awards");
                var sortedAwards = winner.Value.OrderBy(x => x);

                foreach (var award in sortedAwards)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
