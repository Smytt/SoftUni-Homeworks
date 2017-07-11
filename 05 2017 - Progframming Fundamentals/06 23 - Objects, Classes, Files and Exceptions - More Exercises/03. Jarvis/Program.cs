using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            long energy = long.Parse(Console.ReadLine());
            var robot = AddParts();

            if (!RobotIsValid(robot, energy)) return;

            var sortedRobot = SortRobot(robot, energy);

            Console.WriteLine("Jarvis:");

            Console.WriteLine($"#{sortedRobot[0].type}:");
            Console.WriteLine($"###Energy consumption: {sortedRobot[0].energy}");
            Console.WriteLine($"###IQ: {sortedRobot[0].prop1}");
            Console.WriteLine($"###Skin material: {sortedRobot[0].prop2}");

            Console.WriteLine($"#{sortedRobot[1].type}:");
            Console.WriteLine($"###Energy consumption: {sortedRobot[1].energy}");
            Console.WriteLine($"###Processor size: {double.Parse(sortedRobot[1].prop1):f1}");
            Console.WriteLine($"###Corpus material: {sortedRobot[1].prop2}");

            Console.WriteLine($"#{sortedRobot[4].type}:");
            Console.WriteLine($"###Energy consumption: {sortedRobot[4].energy}");
            Console.WriteLine($"###Reach: {sortedRobot[4].prop1}");
            Console.WriteLine($"###Fingers: {sortedRobot[4].prop2}");

            Console.WriteLine($"#{sortedRobot[5].type}:");
            Console.WriteLine($"###Energy consumption: {sortedRobot[5].energy}");
            Console.WriteLine($"###Reach: {sortedRobot[5].prop1}");
            Console.WriteLine($"###Fingers: {sortedRobot[5].prop2}");

            Console.WriteLine($"#{sortedRobot[2].type}:");
            Console.WriteLine($"###Energy consumption: {sortedRobot[2].energy}");
            Console.WriteLine($"###Strength: {sortedRobot[2].prop1}");
            Console.WriteLine($"###Speed: {sortedRobot[2].prop2}");

            Console.WriteLine($"#{sortedRobot[3].type}:");
            Console.WriteLine($"###Energy consumption: {sortedRobot[3].energy}");
            Console.WriteLine($"###Strength: {sortedRobot[3].prop1}");
            Console.WriteLine($"###Speed: {sortedRobot[3].prop2}");



        }
        private static List<RobotPart> SortRobot(List<RobotPart> robot, long energy)
        {
            var sortedRobot = new List<RobotPart>();
            var sortedArms = new List<RobotPart>();
            var sortedLegs = new List<RobotPart>();

            sortedArms = robot.Where(x => x.type == "Arm").OrderBy(x => x.energy).ToList();
            sortedLegs = robot.Where(x => x.type == "Leg").OrderBy(x => x.energy).ToList();

            sortedRobot.Add(robot.First(x => x.type == "Head"));
            sortedRobot.Add(robot.First(x => x.type == "Torso"));
            sortedRobot = sortedRobot.Concat(sortedLegs).Concat(sortedArms).ToList();

            return sortedRobot;
        }

        private static bool RobotIsValid(List<RobotPart> robot, long energy)
        {
            if (robot.Count < 6)
            {
                Console.WriteLine("We need more parts!");
                return false;
            }


            if (energy < robot.Select(x => x.energy).Sum(y => (long)y))
            {
                Console.WriteLine("We need more power!");
                return false;
            }

            return true;
        }

        private static List<RobotPart> AddParts()
        {
            var robot = new List<RobotPart>();
            var command = Console.ReadLine().Split().ToList();
            while (command[0] != "Assemble!")
            {
                var component = new RobotPart();
                component.type = command[0].ToUpper()[0] + command[0].ToLower().Substring(1);
                component.energy = int.Parse(command[1]);
                component.prop1 = command[2];
                component.prop2 = command[3];
                var occurence = robot.Select((x, i) => x.type == component.type ? i : -1).Where(ind => ind > -1).ToList();

                if (occurence.Count == 0) robot.Add(component);
                else if (occurence.Count == 1)
                {
                    if (component.type == "Leg" || component.type == "Arm")
                        robot.Add(component);
                    else
                    {
                        if (component.energy < robot[occurence[0]].energy)
                        {
                            robot.RemoveAt(occurence[0]);
                            robot.Add(component);
                        }
                    }
                }
                else
                {
                    if (component.energy < robot[occurence[0]].energy)
                    {
                        robot.RemoveAt(occurence[0]);
                        robot.Add(component);
                    }
                    else if (component.energy < robot[occurence[1]].energy)
                    {
                        robot.RemoveAt(occurence[1]);
                        robot.Add(component);
                    }
                }

                command = Console.ReadLine().Split().ToList();
            }
            return robot;
        }
    }

    internal class RobotPart
    {
        public string type { get; set; }
        public int energy { get; set; }
        public string prop1 { get; set; }
        public string prop2 { get; set; }
    }
}
