using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();
            SortedDictionary<string, double> townsTotal = TotalSalesByTown(sales);

            foreach(var town in townsTotal)
            {
                Console.WriteLine($"{town.Key}" + " -> " + $"{town.Value:f2}");
            }
        }

        private static SortedDictionary<string, double> TotalSalesByTown(Sale[] sales)
        {
            SortedDictionary<string, double> salesByTOwn = new SortedDictionary<string, double>();

            foreach(var sale in sales)
            {
                if (salesByTOwn.ContainsKey(sale.town))
                {
                    salesByTOwn[sale.town] += sale.total;
                }
                else salesByTOwn[sale.town] = sale.total;

            }
            return salesByTOwn;
        }

        private static Sale[] ReadSales()
        {
            var n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                Sale sale = new Sale();
                var command = Console.ReadLine().Split().ToList();
                sale.town = command[0];
                sale.product = command[1];
                sale.price = double.Parse(command[2]);
                sale.qty = double.Parse(command[3]);

                sales[i] = sale;
            }

            return sales;
        }
    }

    internal class Sale
    {
        public string town { get; set; }
        public string product { get; set; }
        public double price { get; set; }
        public double qty { get; set; }

        public double total { get { return price* qty; } }
    }
}
