using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = ReadTowns();

            var sortedTowns = towns.OrderBy(x => x.name).ToList();

            var totalgroups = towns.Select(x => x.groups.Count).Sum();

            Console.WriteLine($"Created {totalgroups} groups in {towns.Count} towns:");

            foreach (var town in sortedTowns)
            {
                foreach(var group in town.groups)
                {
                    Console.WriteLine(town.name + " => " + string.Join(", ", group.Select(x => x.mail)));
                }
            }

        }

        private static List<Town> ReadTowns()
        {
            var command = Console.ReadLine()
                .Split(new string[] { "=>", "|" }, StringSplitOptions.None)
                .Select(x => x.Trim())
                .ToList();
            var towns = new List<Town>();
            var currentTown = "";

            while (command[0] != "End")
            {
                if (command.Count == 2)
                {
                    currentTown = command[0];
                    var town = new Town();
                    var allStudents = new List<Student>();
                    town.name = command[0];
                    town.capacity = int.Parse(command[1].Split().First());
                    town.allStudents = allStudents;
                    towns.Add(town);
                }
                else
                {
                    var student = new Student();
                    student.name = command[0];
                    student.mail = command[1];
                    student.registrationDate = DateTime.ParseExact(command[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    towns[towns.Count - 1].allStudents.Add(student);
                }

                command = Console.ReadLine()
                .Split(new string[] { "=>", "|" }, StringSplitOptions.None)
                .Select(x => x.Trim())
                .ToList();
            }

            return towns;
        }
    }

    internal class Student
    {
        public string name { get; set; }
        public string mail { get; set; }
        public DateTime registrationDate { get; set; }
    }

    internal class Town
    {
        public string name { get; set; }
        public int capacity { get; set; }
        public List<Student> allStudents { get; set; }
        public List<Student> sortedStudents { get {
                return allStudents
                        .OrderBy(x => x.registrationDate)
                        .ThenBy(x => x.name)
                        .ThenBy(x => x.mail)
                        .ToList();
            } }
        public List<List<Student>> groups { get {
                var groups = new List<List<Student>>();
                var remainingStudents = sortedStudents;
                while(remainingStudents.Count > 0)
                {
                    var group = remainingStudents.Take(capacity).ToList();
                    var nextRemainingStudents = remainingStudents.Skip(capacity).ToList();
                    remainingStudents = nextRemainingStudents;
                    groups.Add(group);
                }

                return groups;
            } }
    }
}
