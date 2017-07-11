using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            resources["fragments"] = 0;
            resources["shards"] = 0;
            resources["motes"] = 0;
            var junk = new SortedDictionary<string, int>();
            var loopBreaker = false;

            while (!loopBreaker)
            {
                var command = Console.ReadLine().ToLower().Split().ToList();
                for (int i = 1; i < command.Count; i += 2)
                {
                    if (resources.ContainsKey(command[i]))
                        resources[command[i]] += int.Parse(command[i - 1]);
                    else if (junk.ContainsKey(command[i]))
                        junk[command[i]] += int.Parse(command[i - 1]);
                    else
                        junk[command[i]] = int.Parse(command[i - 1]);

                    if (resources["fragments"] >= 250)
                    {
                        resources["fragments"] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        loopBreaker = true;
                        break;
                    }
                    if (resources["shards"] >= 250)
                    {
                        resources["shards"] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        loopBreaker = true;
                        break;
                    }
                    if (resources["motes"] >= 250)
                    {
                        resources["motes"] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        loopBreaker = true;
                        break;
                    }
                }
            }

            var sortedResources = resources
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var res in sortedResources)
                Console.WriteLine(res.Key + ": " + res.Value);
            foreach (var garbage in junk)
                Console.WriteLine(garbage.Key + ": " + garbage.Value);
        }
    }
}
