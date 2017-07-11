using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var events = new Dictionary<string, List<string>>();

            while (command != "Time for Code")
            {
                var entry = Regex.Split(command, @"\s+").Where(x => x != "").ToList();
                var id = entry[0];
                var eventName = entry[1];
                var participants = entry.Skip(2).ToList();

                if (IsInvalid(entry))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (events.ContainsKey(id))
                {
                    if (events[id][0] == eventName)
                    {
                        events[id] = events[id].Concat(participants).Distinct().ToList();
                    }
                }
                else
                {
                    events[id] = new List<string>() { eventName };
                    events[id] = events[id].Concat(participants).Distinct().ToList();

                }
                command = Console.ReadLine();
            }

            var sortedEvents = events.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value[0]);
            foreach (var oneEvent in sortedEvents)
            {
                Console.WriteLine($"{oneEvent.Value[0].Substring(1)} - {oneEvent.Value.Count - 1}");
                var sortedPlayers = oneEvent.Value.Skip(1).OrderBy(x => x).ToList();
                foreach (var player in sortedPlayers)
                {
                    if (player[0] == '#') continue;
                    Console.WriteLine(player);
                }
            }
        }

        private static bool IsInvalid(List<string> entry)
        {

            if (entry[1][0] != '#') return true;

            for (int i = 2; i < entry.Count; i++)
            {
                if (entry[i][0] != '@') return true;
            }

            return false;
        }
    }
}
