using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split('|').ToList();
            var populationData = new Dictionary<string, Dictionary<string, long>>();

            while(command[0] != "report")
            {
                var city = command[0];
                var country = command[1];
                long population = long.Parse(command[2]);

                if (populationData.ContainsKey(command[1]))
                {
                    if (populationData[country].ContainsKey(city))
                    {
                        populationData[country][city] += population;
                    }
                    else populationData[country][city] = population;
                }
                else
                    populationData[country] = new Dictionary<string, long>() { { city, population } };

                command = Console.ReadLine().Split('|').ToList();
            }

            var populationDataSorted = populationData
                .OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x=>x.Key, x=>x.Value);

            foreach(var country in populationDataSorted)
            {
                var totalpopulation = country.Value.Select(x => x.Value).Sum();
                Console.WriteLine($"{country.Key} (total population: {totalpopulation})");

                var citiesSorted = country.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach(var city in citiesSorted)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
