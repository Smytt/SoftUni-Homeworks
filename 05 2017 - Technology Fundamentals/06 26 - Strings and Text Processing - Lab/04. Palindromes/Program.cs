using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var palindromes = new List<string>();

            foreach (var word in text)
            {
                var reversedWord = new String(word.ToCharArray().Reverse().ToArray());
                if (word == reversedWord && !palindromes.Contains(word)) palindromes.Add(word);
            }
            palindromes.Sort();
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
