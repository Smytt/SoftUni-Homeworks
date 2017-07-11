using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Where(x => x != "").ToList();
            var game = new List<GameEntry>();

            foreach (var item in input)
            {
                var gameEntry = new GameEntry();
                gameEntry.Start = item[0];
                gameEntry.End = item.Last();
                gameEntry.Number = int.Parse(item.Substring(1, item.Length - 2));
                game.Add(gameEntry);
            }

            var total = 0.0;

            foreach (var gameEntry in game)
            {
                total += gameEntry.Result;
            }
            Console.WriteLine($"{total:f2}");
        }
    }

    internal class GameEntry
    {
        public char Start { get; set; }
        public char End { get; set; }
        public int Number { get; set; }
        public double Result
        {
            get
            {
                var result = (double)Number;
                if (Start >= 'A' && Start <= 'Z')
                {
                    result /= (Start - 'A' + 1);
                }
                else
                {
                    result *= (Start - 'a' + 1);
                }
                if (End >= 'A' && End <= 'Z')
                {
                    result -= End - 'A' + 1;
                }
                else
                {
                    result += End - 'a' + 1;
                }
                return result;
            }
        }
    }
}
