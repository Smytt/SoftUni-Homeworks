using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(new char[] { ' ', '=' }).ToList();
            var users = new SortedDictionary<string, Dictionary<string, int>>();

            while (command[0] != "end")
            {
                var username = command.Last();
                var ip = command[1];

                if (users.ContainsKey(username))
                {
                    if(users[username].ContainsKey(ip))
                    {
                        users[username][ip]++;
                    }
                    else
                    {
                        users[username][ip] = 1;
                    }
                }
                else
                    users[username] = new Dictionary<string, int>() { { ip, 1 } };

                command = Console.ReadLine().Split(new char[] { ' ', '=' }).ToList();
            }

            foreach(var user in users)
            {
                Console.WriteLine(user.Key + ":");
                Console.WriteLine(String.Join(", ", user.Value.Select(x => x.Key + " => " + x.Value)) + ".");
            }
        }
    }
}
