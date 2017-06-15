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

            List<int> maxSeqencesforIndex = new List<int>();
            List<int> prevIndex = new List<int>();

            maxSeqencesforIndex.Add(1);
            prevIndex.Add(0);

            for (int i = 1; i < numbers.Count; i++)
            {

                var maxLeft = numbers.Take(i+1).Min();
                if (maxLeft == numbers[i])
                {
                    maxSeqencesforIndex.Add(1);
                    prevIndex.Add(0);
                    continue;
                }
                var maxLeftIndex = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (numbers[j] > maxLeft && numbers[j]<numbers[i] )
                    {
                        maxLeft = numbers[j];
                        maxLeftIndex = j;
                    }
                }
                maxSeqencesforIndex.Add(maxSeqencesforIndex[maxLeftIndex] + 1);
                prevIndex.Add(maxLeftIndex);
            }

            var maxSequence = 0;
            var maxSequenceIndex = 0;
            for (int i = 0; i < maxSeqencesforIndex.Count; i++)
            {
                if(maxSeqencesforIndex[i] > maxSequence)
                {
                    maxSequence = maxSeqencesforIndex[i];
                    maxSequenceIndex = i;
                }
            }

            List<int> lis = new List<int>();

            var nextIndexToAddToLis = maxSequenceIndex;
            for (int i = 0; i < maxSequence; i++)
            {
                lis.Insert(0, numbers[nextIndexToAddToLis]);
                nextIndexToAddToLis = prevIndex[nextIndexToAddToLis];
            }

            Console.WriteLine(String.Join(" ", lis));
        }
    }
}
