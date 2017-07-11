using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = ReadTeams();
            AddMembers(teams);

            foreach (var team in teams)
            {
                var sortedMembers = team.teamMembers.OrderBy(x => x).ToList();
                team.teamMembers = sortedMembers;
            }

            var sortedTeams = teams
                .Where(x => x.teamMembers.Count > 0)
                .OrderByDescending(x => x.teamMembers.Count)
                .ThenBy(x => x.teamName)
                .ToList();


            var disbandedTeams = teams
                .Where(x => x.teamMembers.Count == 0)
                .OrderBy(x => x.teamName)
                .ToList();

            foreach (var team in sortedTeams)
            {
                Console.WriteLine(team.teamName);
                Console.WriteLine("- " + team.creator);

                foreach (var member in team.teamMembers)
                {
                    Console.WriteLine("-- " + member);
                }
            }



            Console.WriteLine($"Teams to disband:");
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.teamName);
            }

        }


        static void AddMembers(List<Team> teams)
        {
            var command = Console.ReadLine();
            while (command != "end of assignment")
            {
                var memberInfo = command.Split(new string[] { "->" }, StringSplitOptions.None).ToList();
                var teamIndex = teams.FindIndex(x => x.teamName == memberInfo[1]);
                var memberNameIndex = teams.FindIndex(x => x.teamMembers.Any(member => member == memberInfo[0]));
                if (teamIndex < 0)
                {
                    Console.WriteLine($"Team {memberInfo[1]} does not exist!");
                }
                else if (memberNameIndex >= 0 || teams.Any(x => x.creator == memberInfo[0]))
                {
                    Console.WriteLine($"Member {memberInfo[0]} cannot join team {memberInfo[1]}!");
                }
                else
                {
                    teams[teamIndex].teamMembers.Add(memberInfo[0]);
                }

                command = Console.ReadLine();
            }
        }

        static List<Team> ReadTeams()
        {
            var n = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                var team = new Team();
                var teamMembers = new List<string>();
                var command = Console.ReadLine().Split('-').ToList();
                var creatorIndex = teams.FindIndex(x => x.creator == command[0]);
                var teamNameIndex = teams.FindIndex(x => x.teamName == command[1]);
                team.teamName = command[1];
                team.creator = command[0];
                team.teamMembers = teamMembers;
                if (creatorIndex < 0)
                {
                    if (teamNameIndex < 0)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {command[1]} has been created by {command[0]}!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Team {command[1]} was already created!");
                        continue;
                    }
                }
                else
                {
                    if (teamNameIndex < 0)
                    {
                        Console.WriteLine($"{command[0]} cannot create another team!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Team {command[1]} was already created!");
                        continue;
                    }

                }
            }
            return teams;
        }
    }

    internal class Team
    {
        public string creator { get; set; }
        public string teamName { get; set; }
        public List<string> teamMembers { get; set; }
    }
}