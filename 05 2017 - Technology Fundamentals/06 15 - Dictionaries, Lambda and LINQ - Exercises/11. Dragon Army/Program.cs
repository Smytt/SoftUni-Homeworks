using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().ToList();
                var damage = 0;
                var health = 0;
                var armor = 0;
                if (command[2] == "null") damage = 45;
                else damage = int.Parse(command[2]);
                if (command[3] == "null") health = 45;
                else health = int.Parse(command[3]);
                if (command[4] == "null") armor = 45;
                else armor = int.Parse(command[4]);
                var type = command[0];
                var name = command[1];

                var properties = new Dictionary<string, int>();
                properties["damage"] = damage;
                properties["health"] = health;
                properties["armor"] = armor;

                if (dragons.ContainsKey(type))
                {
                    dragons[type][name] = properties;
                }
                else
                {
                    dragons[type] = new SortedDictionary<string, Dictionary<string, int>>();
                    dragons[type].Add(name, properties);
                }
            }

            foreach (var type in dragons)
            {
                double avgDamage = 0;
                double avgHealth = 0;
                double avgArmor = 0;

                foreach (var name in type.Value)
                {
                    avgDamage += name.Value["damage"];
                    avgHealth += name.Value["health"];
                    avgArmor += name.Value["armor"];
                }

                Console.WriteLine($"{type.Key}::({avgDamage / type.Value.Count:f2}/{avgHealth / type.Value.Count:f2}/{avgArmor / type.Value.Count:f2})");

                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value["damage"]}, health: {name.Value["health"]}, armor: {name.Value["armor"]}");                    
                }
            }
        }
    }
}
