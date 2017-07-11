using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var files = new Dictionary<string, List<File>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('\\').ToList();
                var root = input[0];
                var fileAndSize = input.Last().Split(';').ToList();
                var size = long.Parse(fileAndSize.Last());
                var name = fileAndSize.First();
                var ext = name.Split('.').Last();

                if (files.ContainsKey(root))
                {
                    var duplicateIndex = files[root].FindIndex(x => x.Name == name);

                    if (duplicateIndex > -1)
                    {
                        files[root].RemoveAt(duplicateIndex);
                    }
                }
                else
                {
                    files[root] = new List<File>();
                }

                files[root].Add(new File() {
                    Name = name,
                    Ext = ext,
                    Size = size,
                });
            }

            var query = Regex.Split(Console.ReadLine(), @" in ").ToList();

            if (!files.ContainsKey(query[1]) || query.Count != 2)
            {
                Console.WriteLine("No");
                return;
            }

            var matchedFiles = files[query[1]]
                .Where(x => x.Ext == query[0])
                .OrderByDescending(x => x.Size)
                .ThenBy(x => x.Name)
                .ToList();

            if (matchedFiles.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            foreach (var file in matchedFiles)
            {
                Console.WriteLine(file);
            }
        }
    }

    internal class File
    {
        public string Name { get; set; }
        public string Ext { get; set; }
        public long Size { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            return sb.Append(Name).Append(" - ")
                .Append(Size).Append(" KB").ToString();
        }
    }
}
