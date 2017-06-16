using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var numbersAndSequences = new Dictionary<int, List<int>>();
            numbersAndSequences[0] = new List<int>() { numbers[0] };

            for (int i = 1; i < numbers.Count; i++)
            {
                var filtered = numbers.Take(i)
                    .Select((v, index) => new { v, index })
                    .Where(kvp => kvp.v < numbers[i]).ToList();

                int prevMaxCount = 0;
                int prevMaxCountIndex = 0;

                if (filtered.Count == 0)
                {
                    prevMaxCount = -1;
                    numbersAndSequences[i] = new List<int>() { numbers[i] };
                }
                else
                {

                    foreach (var item in numbersAndSequences)
                    {
                        if (filtered.Select(x => x.index).Contains(item.Key))
                        {
                            if (item.Value.Count > prevMaxCount)
                            {
                                prevMaxCount = item.Value.Count;
                                prevMaxCountIndex = item.Key;
                            }
                            
                        }
                    }

                    var newMember = new List<int>() { numbers[i] };
                    numbersAndSequences[i] = numbersAndSequences[prevMaxCountIndex].Concat(newMember).ToList();
                }
            }

            var longestSeqCount = numbersAndSequences.Select(kvp => kvp.Value.Count).Max();
            var lis = numbersAndSequences.First(kvp => kvp.Value.Count == longestSeqCount).Value.ToList();
            Console.WriteLine(string.Join(" ",lis));
            
        }
    }
}
