using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var users = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToList();
                var name = line[1];
                var ip = line[0];
                var time = int.Parse(line[2]);

                if(users.ContainsKey(name))
                {
                    if(users[name].ContainsKey(ip))
                    {
                        users[name][ip] += time;
                    }
                    else
                        users[name][ip] = time;
                }
                else
                {
                    users[name] = new Dictionary<string, int>() { { ip, time } };
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Key + ": " +
                    user.Value.Values.Sum() + " [" +
                    string.Join(", ", user.Value.Keys.OrderBy(x => x)) + "]");
            }
        }
    }
}
