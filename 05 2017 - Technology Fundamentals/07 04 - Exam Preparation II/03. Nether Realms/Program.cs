using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Regex.Split(Console.ReadLine(), @" *, *").Where(x => x!= "").ToList();
            var matchHealth = @"[^0-9+./*-]";
            var matchDamage = @"[+-]?[0-9]+(\.[0-9]+)?";
            var matchMultipliers = @"[*/]";
            var sortedDemons = new SortedDictionary<string, List<decimal>>();

            foreach (var demon in demons)
            {
                sortedDemons[demon] = new List<decimal>() { 0.0m, 0.0m };
                var getHealth = Regex.Matches(demon, matchHealth);
                foreach (Match match in getHealth)
                {
                    sortedDemons[demon][0] += match.ToString().ToCharArray()[0];
                }
                var getDamage = Regex.Matches(demon, matchDamage);
                foreach (Match match in getDamage)
                {
                    sortedDemons[demon][1] += decimal.Parse(match.ToString());
                }
                var getMultipliers = Regex.Matches(demon, matchMultipliers);
                foreach (Match match in getMultipliers)
                {
                    if(match.ToString() == "/") sortedDemons[demon][1] /= 2;
                    if(match.ToString() == "*") sortedDemons[demon][1] *= 2;
                }
            }

            foreach (var demon in sortedDemons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]:f0} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}
