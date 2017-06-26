using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = ReadStudents();

            PrintStudentsWithBetterGrade(students, 5.00);
        }

        static void PrintStudentsWithBetterGrade(Student[] students, double grade)
        {
            var selectedStudents = students
                .Select(x => new { x.name, x.average })
                .Where(stud => stud.average >= 5)
                .OrderBy(x => x.name)
                .ThenByDescending(x => x.average)
                .ToList();          

            foreach(var student in selectedStudents)
            {
                Console.WriteLine($"{student.name} -> {student.average:f2}");
            }

        }

        static Student[] ReadStudents()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                var student = new Student();
                var command = Console.ReadLine().Split().ToList();
                var allGrades = command.Skip(1).Select(double.Parse).ToList();

                student.name = command[0];
                student.allGrades = allGrades;
                students[i] = student;
            }
            return students;


        }
    }

    internal class Student
    {
        public string name { get; set; }
        public List<double> allGrades { get; set; }
        public double average { get { return allGrades.Sum() * 1.00 / allGrades.Count; } }
    }
}
