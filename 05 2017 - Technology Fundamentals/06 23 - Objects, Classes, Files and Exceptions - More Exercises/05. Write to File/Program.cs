using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("sample_text.txt");
            var chars = text.Where(c => ".,?!:".IndexOf(c) == -1 ).ToArray();

            File.WriteAllText("output1.txt", string.Join("", chars));
        }
    }
}
