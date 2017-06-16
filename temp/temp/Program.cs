using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 11, 2, 12, 2, 4, 4, 6, 2, 7 };

            //int test = list.IndexOf(list.Last(x => x == 2));
            int test = numbers.Take(5)
                    .Select((v, index) => new { v, index })
                    .Where(x => x.v < numbers[5]).Max(x => x.v);

            Console.WriteLine(test);
        }
    }
}