using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().ToList();
            var camera = Console.ReadLine();
            var pattern = @"\|<[^|<]{" + nums[0] + @"}(?<view>[^|<]{0," + nums[1] + @"})";

            var views = Regex.Matches(camera, pattern).Cast<Match>().Select(x => x.Groups["view"].Value).ToList();


            Console.WriteLine(string.Join(", ", views));
        }
    }
}
