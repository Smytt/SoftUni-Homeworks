using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine();
            var pattern = Console.ReadLine();
            var shake = true;

            while(shake)
            {
                var tokens = sequence.Split(new string[] { pattern }, StringSplitOptions.None).ToList().Count;

                if (tokens < 3) break;

                Console.WriteLine("Shake it.");

                sequence = sequence.Remove(sequence.IndexOf(pattern), pattern.Length);
                sequence = sequence.Remove(sequence.LastIndexOf(pattern), pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(sequence);
        }
    }
}
