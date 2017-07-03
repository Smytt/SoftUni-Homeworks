using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = new List<Player>();
            var names = Console.ReadLine().Split().ToList();

            foreach (var name in names)
            {
                var player = new Player();
                player.Name = name;
                participants.Add(player);
            }

            var zones = Console.ReadLine().Split().Select(double.Parse).ToList();
            var checkpoints = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < zones.Count; i++)
            {
                var sign = 1;
                if (checkpoints.Any(x => x == i)) sign = -1;

                foreach(var player in participants)
                {
                    if (i == 0) player.CurrentFuel = player.InitialFuel;
                    if (player.CurrentFuel <= 0) continue;
                    player.CurrentFuel -= zones[i] * sign;
                    if (player.CurrentFuel <= 0) player.ExitIndex = i;
                }
            }

            foreach (var player in participants)
            {
                Console.WriteLine(player);
            }
        }
    }

    internal class Player
    {
        public string Name { get; set; }
        public double CurrentFuel { get; set; }
        public int ExitIndex { get; set; }
        public int InitialFuel { get { return (int)Name[0]; } }
        public override string ToString()
        {
            if (CurrentFuel <= 0) return $"{Name} - reached {ExitIndex}";
            return $"{Name} - fuel left {CurrentFuel:f2}";
        }
    }
}
