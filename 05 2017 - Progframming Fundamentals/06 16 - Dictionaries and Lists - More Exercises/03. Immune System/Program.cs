using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            int health = initialHealth;
            int remainingHealth = 0;
            string virusName = Console.ReadLine();
            List<string> oldViruses = new List<string>();

            while (virusName != "end")
            {
                int virusStrength = virusName.ToCharArray().Select(x => (int)x).Sum() / 3;
                int virusTimeToDefeat = virusStrength * virusName.Length;
                if (oldViruses.Contains(virusName)) virusTimeToDefeat /= 3;
                else oldViruses.Add(virusName);
                remainingHealth = health - virusTimeToDefeat;

                Console.WriteLine($"Virus {virusName}: {virusStrength} => {virusTimeToDefeat} seconds");

                if (virusTimeToDefeat > health)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                Console.WriteLine($"{virusName} defeated in {virusTimeToDefeat / 60}m {virusTimeToDefeat % 60}s.");
                Console.WriteLine($"Remaining health: {remainingHealth}");
                health = (int)((remainingHealth) * 1.2);
                if (health > initialHealth) health = initialHealth;

                virusName = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {health}");
        }
    }
}
