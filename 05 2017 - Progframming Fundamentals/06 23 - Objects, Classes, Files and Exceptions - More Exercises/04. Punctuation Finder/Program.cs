using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("sample_text.txt");
            var chars = text.Where(c => new char[] { '.', ',', '?', '!', ':' }.Any(i => i == c)).ToArray();

            File.WriteAllText("output.txt", string.Join(", ", chars));
        }
    }
}
