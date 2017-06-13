using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> removeLines =
                Console.ReadLine()
                .Split('|')
                .ToList();

            for (int i = removeLines.Count - 1; i >= 0; i--)
            {
                var partString = removeLines[i].Trim().Split(' ').ToList();
                var noEmptyItems = new List<int>();

                foreach (var num in partString)
                {
                    if (num.Length != 0) noEmptyItems.Add(int.Parse(num));
                }
                removeLines[i] = String.Join(" ", noEmptyItems);
            }

            removeLines.Reverse();
            Console.WriteLine(String.Join(" ", removeLines));
        }
    }
}
