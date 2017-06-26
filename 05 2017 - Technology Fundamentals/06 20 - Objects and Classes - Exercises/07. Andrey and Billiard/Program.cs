using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> menu = ReadMenu();
            var command = Console.ReadLine();
            var buyers = new SortedDictionary<string, Client>();

            while (command != "end of clients")
            {
                var client = new Client();
                var clientOrder = command.Split(new char[] { '-', ',' }).ToList();
                var name = clientOrder[0];
                var product = clientOrder[1];
                var qty = int.Parse(clientOrder[2]);

                if (!menu.ContainsKey(product))
                {
                    command = Console.ReadLine();
                    continue;
                }
                
                if (buyers.ContainsKey(name))
                {
                    if (buyers[name].orders.ContainsKey(product))
                        buyers[name].orders[product] += qty;
                    else
                        buyers[name].orders[product] = qty;
                }
                else
                {
                    var orders = new Dictionary<string, int>();
                    client.name = name;
                    client.orders = orders;
                    client.orders[product] = qty;
                    buyers[name] = client;
                }
                command = Console.ReadLine();
            }
            var grandTotal = 0.0;
            foreach (var buyer in buyers)
            {
                Console.WriteLine(buyer.Key);
                var total = 0.0;
                foreach (var purchase in buyer.Value.orders)
                {
                    Console.WriteLine($"-- {purchase.Key} - {purchase.Value}");
                    total += purchase.Value * menu[purchase.Key];
                }
                grandTotal += total;
                buyer.Value.bill = total;

                Console.WriteLine($"Bill: {buyer.Value.bill:f2}");
            }
            Console.WriteLine($"Total bill: {grandTotal:f2}");

        }

        private static Dictionary<string, double> ReadMenu()
        {
            var menu = new Dictionary<string, double>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var menuEntry = Console.ReadLine().Split('-').ToList();
                menu[menuEntry[0]] = double.Parse(menuEntry[1]);
            }
            return menu;
        }
    }

    internal class Client
    {
        public string name { get; set; }
        public Dictionary<string, int> orders { get; set; }
        public double bill { get; set; }
    }
}
