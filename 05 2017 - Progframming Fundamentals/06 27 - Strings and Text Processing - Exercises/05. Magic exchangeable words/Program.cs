using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split().ToArray();

            Console.WriteLine(AreExchangeable(strings[0], strings[1])? "true" : "false");
        }

        private static bool AreExchangeable(string v1, string v2)
        {
            var uniquev1 = v1.ToCharArray().Distinct().ToList().Count;
            var uniquev2 = v2.ToCharArray().Distinct().ToList().Count;

            return uniquev1 == uniquev2;
        }
    }
}
