using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //var command = Console.ReadLine()
            //    .Split(new char[] { ' ', ',', ':' })
            //    .Where(x => x != "")
            //    .Distinct()
            //    .ToList();

            var command = Console.ReadLine()
                .Split(':')
                .ToArray();

            var players = new Dictionary<string, List<string>>();

            while (command[0] != "JOKER")
            {
                var currentDraw = command[1]
                    .Split(new char[] { ' ', ',' })
                    .Where(x => x != "")
                    .Distinct()
                    .ToList();

                if (players.ContainsKey(command[0]))
                    players[command[0]] =
                        players[command[0]]
                        .Concat(currentDraw)
                        .Distinct()
                        .ToList();
                else
                    players[command[0]] = currentDraw.Distinct().ToList();

                command = Console.ReadLine()
                .Split(':')
                .ToArray();
            }

            var pointsForPlayers = new Dictionary<string, int>();

            foreach (var person in players)
            {
                var totalpoints = 0;

                for (int i = 0; i < person.Value.Count; i++)
                {
                    var currentCard = person.Value[i];
                    var type = currentCard.Last();
                    var muliplier = 0;
                    switch (type)
                    {
                        case 'S': muliplier = 4; break;
                        case 'H': muliplier = 3; break;
                        case 'D': muliplier = 2; break;
                        case 'C': muliplier = 1; break;
                    }
                    var powerString = currentCard.Substring(0, currentCard.Length - 1);
                    int power = 0;
                    switch (powerString)
                    {
                        case "J": power = 11; break;
                        case "Q": power = 12; break;
                        case "K": power = 13; break;
                        case "A": power = 14; break;
                        default: power = int.Parse(powerString); break;
                    }
                    totalpoints += power * muliplier;
                }

                pointsForPlayers[person.Key] = totalpoints;
            }

            foreach (var player in pointsForPlayers)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
    }
}