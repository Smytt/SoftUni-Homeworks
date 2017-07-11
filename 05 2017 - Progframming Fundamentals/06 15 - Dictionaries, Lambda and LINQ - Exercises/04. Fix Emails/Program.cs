using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var mailsBook = new Dictionary<string, string>();

            while (command != "stop")
            {
                var mail = Console.ReadLine().Split('.').ToList();
                if (mail.Last().ToLower() != "uk" && mail.Last().ToLower() != "us")
                {
                    mailsBook[command] = String.Join(".", mail);
                }
                command = Console.ReadLine();
            }

            foreach(var person in mailsBook)
                Console.WriteLine($"{person.Key} -> {person.Value}");
        }
    }
}
