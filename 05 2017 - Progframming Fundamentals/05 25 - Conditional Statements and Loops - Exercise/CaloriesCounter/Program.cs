using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cal = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese": cal += 500; break;
                    case "tomato sauce": cal += 150; break;
                    case "salami": cal += 600; break;
                    case "pepper": cal += 50; break;
                }
            }

            Console.WriteLine($"Total calories: {cal}");
        }
    }
}
