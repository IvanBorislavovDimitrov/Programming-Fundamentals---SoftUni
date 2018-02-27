using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();
            CalculateWorkingDays(startDate, endDate);
        }

        private static void CalculateWorkingDays(string start, string end)
        {
            DateTime startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int countOfWorkingDays = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if ((date.Day == 3 && date.Month == 3) ||
                    (date.Day == 1 && date.Month == 1) ||
                    (date.Day == 1 && date.Month == 5) ||
                    (date.Day == 6 && date.Month == 5) ||
                    (date.Day == 24 && date.Month == 5) ||
                    (date.Day == 6 && date.Month == 9) ||
                    (date.Day == 22 && date.Month == 9) ||
                    (date.Day == 1 && date.Month == 11) ||
                    ((date.Day == 24 || date.Day == 25 || date.Day == 26) && date.Month == 12) ||
                    (date.DayOfWeek == DayOfWeek.Saturday) ||
                    (date.DayOfWeek == DayOfWeek.Sunday))
                {
                    continue;
                }
                countOfWorkingDays++;
            }
            Console.WriteLine(countOfWorkingDays);
        }
    }
}