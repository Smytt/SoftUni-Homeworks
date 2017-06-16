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

            var lisDict = new Dictionary<int, List<int>>();
            lisDict[0] = new List<int>() { numbers[0] };

            for (int i = 1; i < numbers.Count; i++)
            {
                int maxLeft; int maxLeftIndex = -1;

                var MaxLeftObj = numbers.Take(i)
                    .Select((v, index) => new { v, index })
                    .Where(x => x.v < numbers[i]).ToList();

                if (MaxLeftObj.Count > 0)
                {
                    maxLeft = MaxLeftObj.Max(x => x.v);
                    maxLeftIndex = MaxLeftObj.Max(x => x.index);
                }

                if (lisDict.ContainsKey(maxLeftIndex))
                {
                    lisDict[i] = lisDict[maxLeftIndex].Concat(new List<int>() { numbers[i] }).ToList();
                }
                else
                    lisDict[i] = new List<int>() { numbers[i] };

            }

            var maxSequence = lisDict.Select((k, v) => v).Max();
            Console.WriteLine(maxSequence);
        }
    }
}
