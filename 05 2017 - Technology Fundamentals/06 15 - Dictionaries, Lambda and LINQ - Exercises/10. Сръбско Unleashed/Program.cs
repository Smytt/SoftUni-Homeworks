using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split('@').ToList();
            var venues = new Dictionary<string, Dictionary<string, long>>();

            while (command[0] != "End")
            {
                if (!command[0].EndsWith(" "))
                {
                    command = Console.ReadLine().Split('@').ToList();
                    continue;
                }
                var name = command[0].Trim();
                var commandRightPart = command[1].Trim().Split().ToList();
                var venue = String.Join(" ", commandRightPart.Take(commandRightPart.Count - 2));
                long qty;
                int price;

                try
                {
                    price = int.Parse(commandRightPart[commandRightPart.Count - 2]);
                    qty = long.Parse(commandRightPart[commandRightPart.Count - 1]);
                }
                catch (Exception)
                {
                    command = Console.ReadLine().Split('@').ToList();
                    continue;
                }

                if (venues.ContainsKey(venue))
                {
                    if (venues[venue].ContainsKey(name))
                    {
                        venues[venue][name] += qty * price;
                    }
                    else
                        venues[venue][name] = qty * price;
                }
                else
                    venues[venue] = new Dictionary<string, long>() { { name, qty * price } };

                command = Console.ReadLine().Split('@').ToList();
            }

            foreach (var town in venues)
            {
                Console.WriteLine(town.Key);

                var sortedSingers = town
                    .Value
                    .OrderByDescending(kvp => kvp.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var singer in sortedSingers)
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
    }
}
