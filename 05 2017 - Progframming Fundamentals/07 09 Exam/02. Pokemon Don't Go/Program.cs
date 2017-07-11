using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine().Split().Select(long.Parse).ToList();
            long totalSum = 0;

            while (pokemons.Count > 0)
            {
                long value = 0;
                var index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    value = pokemons[0];
                    pokemons[0] = pokemons.Last();
                }

                else if (index > pokemons.Count - 1)
                {
                    value = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }

                else
                {
                    value = pokemons[index];
                    pokemons.RemoveAt(index);
                }

                pokemons = ProcessPokemons(pokemons, value, totalSum);

                totalSum += value;
            }

            Console.WriteLine(totalSum);
        }

        private static List<long> ProcessPokemons(List<long> pokemons, long value, long totalSum )
        {
            return pokemons.Select(x => x <= value ? (x + value) : (x - value)).ToList();
        }
    }
}
