using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var files = new Dictionary<string, List<File>>();
            var matchRoot = @"^[^\\]+";
            var matchFile = @"([^\\]+)\.([^\\\.]+);([\d]+(?:\.[\d]+)?)$";

            for (int i = 0; i < n; i++)
            {
                var file = new File();
                var dir = Console.ReadLine();
                if (Regex.Match(dir, matchFile).Success == false || Regex.Match(dir, matchRoot).Success == false)
                {
                    continue;
                }
                var root = Regex.Match(dir, matchRoot).Value;
                var fileMatch = Regex.Match(dir, matchFile);
                file.Name = fileMatch.Groups[1].Value;
                file.Extension = fileMatch.Groups[2].Value;
                file.Size = decimal.Parse(fileMatch.Groups[3].Value);

                if (files.ContainsKey(root))
                {
                    var duplicateIndex = files[root].FindIndex(x => x.Name + x.Extension == file.Name + file.Extension);

                    if (duplicateIndex > -1)
                    {
                        files[root].RemoveAt(duplicateIndex);
                    }
                }
                else
                {
                    files[root] = new List<File>();
                }

                files[root].Add(file);
            }

            var query = Regex.Split(Console.ReadLine(), @" in ").ToList();

            if (!files.ContainsKey(query[1]) || query.Count != 2)
            {
                Console.WriteLine("No");
                return;
            }

            var matchedFiles = files[query[1]]
                .Where(x => x.Extension == query[0])
                .OrderByDescending(x => x.Size)
                .ThenBy(x => x.Name)
                .ToList();

            if (matchedFiles.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            foreach(var file in matchedFiles)
            {
                Console.WriteLine(file);
            }

        }
    }

    internal class File
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public decimal Size { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            return sb.Append(Name).Append('.')
                .Append(Extension).Append(" - ")
                .Append(Size).Append(" KB").ToString();
        }
    }
}
