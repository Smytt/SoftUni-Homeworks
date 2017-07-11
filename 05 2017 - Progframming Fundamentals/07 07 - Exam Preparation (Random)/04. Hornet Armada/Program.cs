using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legions = new List<Legion>();

            for (int i = 0; i < n; i++)
            {
                var command = Regex.Split(Console.ReadLine(), @"( = | -> |:)").ToList();
                var legionName = command[1];
                var activity = int.Parse(command[0]);
                var soldierType = command[2];
                var soldierCount = int.Parse(command[3]);

                if (!legions.Select(x => x.Name).Contains(legionName))
                {
                    legions.Add(new Legion()
                    {
                        Name = legionName,
                        Activity = activity,
                        Soldiers = new List<Soldier>()
                    });
                }

                var index = legions.FindIndex(x => x.Name == legionName);

                if (activity > legions[index].Activity) legions[index].Activity = activity;
                if (!legions[index].Soldiers.Select(x => x.Name).Contains(soldierType))
                {
                    legions[index].Soldiers.Add(new Soldier()
                    {
                        Name = soldierType,
                        Count = 0
                    });
                }
                var soldierIndex = legions[index].Soldiers.FindIndex(x => x.Name == soldierType);
                legions[index].Soldiers[soldierIndex].Count += soldierCount;
            }

            var finalCommand = Console.ReadLine();
        }
    }

    internal class Legion
    {
        public string Name { get; set; }
        public List<Soldier> Soldiers { get; set; }
        public int Activity { get; set; }
    }

    public class Soldier
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
