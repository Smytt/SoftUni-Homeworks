using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split().ToArray();

            var result = CharacterMultiplier(strings[0], strings[1]);

            Console.WriteLine(result);
        }

        private static int CharacterMultiplier(string v1, string v2)
        {
            var result = 0;
            var minLen = Math.Min(v1.Length, v2.Length);
            var maxLen = Math.Max(v1.Length, v2.Length);

            for (int i = 0; i < minLen; i++)
            {
                result += v1[i] * v2[i];
            }

            for (int i = minLen; i < maxLen; i++)
            {
                try
                {
                    result += v1[i];
                }
                catch
                {
                    result += v2[i];
                }
            }

            return result;


        }
    }
}
