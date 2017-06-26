using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();
            Random pick = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var newIndex = pick.Next(0, words.Count - 1);
                var tempWord = words[newIndex];
                words[newIndex] = words[i];
                words[i] = tempWord;
            }

            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
