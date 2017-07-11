using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var resources = new Dictionary<string, long>();

            while(command != "stop")
            {
                var qty = long.Parse(Console.ReadLine());

                if (resources.ContainsKey(command))
                {
                    resources[command] += qty;
                }
                else resources[command] = qty;

                command = Console.ReadLine();
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
