using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var allPokemon = new Dictionary<string, List<Evolution>>();

            while(input != "wubbalubbadubdub")
            {
                var command = Regex.Split(input, @" -> ").ToList();
                var pokemon = command[0];

                if(command.Count == 1)
                {
                    PrintSinglePokemon(allPokemon, pokemon);
                    input = Console.ReadLine();
                    continue;
                }

                var evolutionType = command[1];
                var evolutionIndex = long.Parse(command[2]);

                if (!allPokemon.ContainsKey(pokemon)) allPokemon[pokemon] = new List<Evolution>();

                allPokemon[pokemon].Add(new Evolution()
                {
                    Type = evolutionType,
                    Index = evolutionIndex,
                });

                input = Console.ReadLine();
            }

            PrintAllPokemon(allPokemon);
        }

        private static void PrintAllPokemon(Dictionary<string, List<Evolution>> allPokemon)
        {
            foreach (var pokemon in allPokemon)
            {
                Console.WriteLine($"# {pokemon.Key}");
                var sortedIndexes = pokemon.Value.OrderByDescending(x => x.Index).ToList();
                foreach (var index in sortedIndexes)
                {
                    Console.WriteLine($"{index.Type} <-> {index.Index}");
                }
            }
        }

        private static void PrintSinglePokemon(Dictionary<string, List<Evolution>> allPokemon, string pokemon)
        {
            if(allPokemon.ContainsKey(pokemon))
            {
                Console.WriteLine($"# {pokemon}");
                foreach(var evolution in allPokemon[pokemon])
                {
                    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                }
            }
        }
    }

    public class Evolution
    {
        public string Type { get; set; }
        public long Index { get; set; }
    }
}
