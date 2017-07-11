using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var teams = new Dictionary<string, Team>();

            var command = Console.ReadLine().Split();

            while(command[0] != "final")
            {
                var teamAName = new string(Regex.Split(command[0], Regex.Escape(key))[1].ToUpper().ToCharArray().Reverse().ToArray());
                var teamBName = new string(Regex.Split(command[1], Regex.Escape(key))[1].ToUpper().ToCharArray().Reverse().ToArray());
                var matchScores = command[2].Split(':').Select(long.Parse).ToArray();

                ProcessTeamInput(teamAName, matchScores, teams);
                ProcessTeamInput(teamBName, matchScores.Reverse().ToArray(), teams);

                command = Console.ReadLine().Split();
            }

            var sortedTeams = teams.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key);
            var sortedByGoals = teams.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3);
            var counter = 1;
            Console.WriteLine("League standings:");
            foreach(var team in sortedTeams)
            {
                Console.WriteLine($"{counter}. {team.Key} {team.Value.Points}");
                counter++;
            }
            Console.WriteLine($"Top 3 scored goals:");
            foreach(var team in sortedByGoals)
            {
                Console.WriteLine($"- {team.Value.Name} -> {team.Value.Goals}");
            }
        }

        private static void ProcessTeamInput(string teamName, long[] matchScores, Dictionary<string, Team> teams)
        {
            var points = 0;
            if (matchScores[0] > matchScores[1]) points = 3;
            else if (matchScores[0] == matchScores[1]) points = 1;

            if (!teams.ContainsKey(teamName)) teams[teamName] = new Team() { Points = 0, Goals = 0, Name = teamName};
            teams[teamName].Goals += matchScores[0];
            teams[teamName].Points += points;
        }
    }

    internal class Team
    {
        public string Name { get; set; }
        public long Points { get; set; }
        public long Goals { get; set; }
    }
}
