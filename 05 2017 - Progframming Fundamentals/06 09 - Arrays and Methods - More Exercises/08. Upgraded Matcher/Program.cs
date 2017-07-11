using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            string inputqty = Console.ReadLine();
            long[] qty = new long[1];
            try
            {
                qty = inputqty.Split(' ').Select(long.Parse).ToArray();
            }
            catch
            {
                qty[0] = 0;
            }
            
            double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            long[] qtyUpdated = new long[products.Length];

            for (int i = 0; i < qty.Length; i++)
            {
                qtyUpdated[i] = qty[i];
            }

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == command[0])
                    {
                        if(long.Parse(command[1]) > qtyUpdated[i])
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                            continue;
                        }
                        Console.WriteLine("{0} x {1} costs {2:f2}",
                            products[i], command[1], price[i]* long.Parse(command[1]));
                        qtyUpdated[i] -= long.Parse(command[1]);
                        break;
                    }
                }
                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
