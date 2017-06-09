using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            string[] qty = Console.ReadLine().Split(' ');
            string[] price = Console.ReadLine().Split(' ');

            string command = Console.ReadLine();

            while (command != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == command)
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}",
                            products[i], price[i], qty[i]);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
