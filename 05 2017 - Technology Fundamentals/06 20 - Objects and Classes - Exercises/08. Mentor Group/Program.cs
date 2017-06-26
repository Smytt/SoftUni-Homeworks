using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = ReadStudents();

            ProcessComments(students);

            var sortedStudents = SortStudents(students);

            PrintComments(sortedStudents);
        }

        static List<Student> SortStudents(List<Student> students)
        {
            var sortedStudents = students.OrderBy(x => x.name).ToList();

            foreach(var student in sortedStudents)
            {
                var sortedDates = student.datesAttended.OrderBy(x => x).ToList();
                student.datesAttended = sortedDates;
            }

            return sortedStudents;
        }

        static void PrintComments(List<Student> students)
        {
            foreach(var student in students)
            {
                Console.WriteLine(student.name);
                Console.WriteLine("Comments:");
                foreach(var comment in student.comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.datesAttended)
                {
                    Console.WriteLine($"-- {date}");
                }
            }
        }

        static void ProcessComments(List<Student> students)
        {
            var command = Console.ReadLine();

            while(command != "end of comments")
            {
                var userAndComment = command.Split('-').ToList();
                var userIndex = students.FindIndex(x => x.name == userAndComment[0]);
                if (userIndex >= 0)
                {
                    students[userIndex].comments.Add(userAndComment[1]);
                }
                command = Console.ReadLine();
            }
        }

        private static List<Student> ReadStudents()
        {
            var students = new List<Student>();
            var command = Console.ReadLine();

            while (command != "end of dates")
            {
                var studentNameAndDates = command.Split(new char[] { ' ', ',' }).ToList();
                var student = new Student();
                var datesList = new List<string>();
                var commentsList = new List<string>();
                var studentIndex = students.FindIndex(x => x.name == studentNameAndDates[0]);
                if (studentIndex >= 0)
                {
                    for (int i = 1; i < studentNameAndDates.Count; i++)
                    {
                        students[studentIndex].datesAttended.Add(studentNameAndDates[i]);
                    }                   
                }
                else
                {
                    student.name = studentNameAndDates[0];
                    student.datesAttended = datesList;
                    student.comments = commentsList;
                    for (int i = 1; i < studentNameAndDates.Count; i++)
                    {
                        student.datesAttended.Add(studentNameAndDates[i]);
                    }
                    students.Add(student);
                }
                command = Console.ReadLine();
            }
            return students;
        }
    }

    internal class Student
    {
        public string name { get; set; }
        public List<string> datesAttended { get; set; }
        public List<string> comments { get; set; }
    }
}
