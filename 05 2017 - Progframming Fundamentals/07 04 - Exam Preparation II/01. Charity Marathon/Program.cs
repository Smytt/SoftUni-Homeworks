using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDays = int.Parse(Console.ReadLine());
            var totalRunners = int.Parse(Console.ReadLine());
            var lapsPerRunner = int.Parse(Console.ReadLine());
            var trackLen = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            if (totalRunners > totalDays * trackCapacity) totalRunners = totalDays * trackCapacity;
            var totalMoney = moneyPerKm * trackLen * totalRunners * lapsPerRunner / 1000;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
            
        }
    }
}
