using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder();
            var line = Console.ReadLine();

            while(string.Compare(line, "end") != 0)
            {
                text.Append(line);
                text.Append("\r\n");
                line = Console.ReadLine();
            }

            var pattern = @"<a(?<tagprop>[^>]+)?>(?<content>[^<]+)<\/a>";

            Regex regex = new Regex(pattern);

            var result = regex.Replace(text.ToString(), "[URL${tagprop}]${content}[/URL]");
            Console.WriteLine(result);
        }
    }
}
