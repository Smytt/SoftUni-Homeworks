using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char sex = 'f';
            long ID = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine($@"First name: {firstName}
Last name: {lastName}
Age: {age}
Gender: {sex}
Personal ID: {ID}
Unique Employee number: {employeeNumber}");

        }
    }
}
