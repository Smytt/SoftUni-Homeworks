using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays = new DateTime[11]
            {
                new DateTime(2000, 1, 1),
                new DateTime(2000, 3, 3),
                new DateTime(2000, 5, 1),
                new DateTime(2000, 5, 6),
                new DateTime(2000, 5, 24),
                new DateTime(2000, 9, 6),
                new DateTime(2000, 9, 22),
                new DateTime(2000, 11, 1),
                new DateTime(2000, 12, 24),
                new DateTime(2000, 12, 25),
                new DateTime(2000, 12, 26),
            };



            var workingDays = 0;

            for (var i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (isWorkingDay(i, holidays)) workingDays++;
            }

            Console.WriteLine(workingDays);
        }

        static bool isWorkingDay(DateTime day, DateTime[] holidays)
        {
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday) return false;
            if (holidays.Any(d => d.Day == day.Day && d.Month == day.Month)) return false;
            return true;
        }
    }
}
