using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var command = Console.ReadLine().Split().ToList();

            while (command[0] != "End")
            {
                var person = new Person();
                person.name = command[0];
                person.age = int.Parse(command[2]);
                person.id = command[1];
                people.Add(person);
                command = Console.ReadLine().Split().ToList();
            }

            var sortedPeople = people.OrderBy(x => x.age);
            foreach(var person in sortedPeople)
            {
                Console.WriteLine($"{person.name} with ID: {person.id} is {person.age} years old.");
            }
        }
    }

    internal class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string id { get; set; }
    }
}
