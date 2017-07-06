using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalMoney = double.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berryPrice = double.Parse(Console.ReadLine());


            long doses = guests / 6;
            if (guests % 6 != 0) doses++;

            var moneyNeeded = (2 * bananaPrice + 4 * eggPrice + 0.2 * berryPrice) * doses;

            if (moneyNeeded <= totalMoney) Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            else Console.WriteLine($"Ivancho will have to withdraw money - he will need {(moneyNeeded - totalMoney):f2}lv more.");
        }
    }
}
