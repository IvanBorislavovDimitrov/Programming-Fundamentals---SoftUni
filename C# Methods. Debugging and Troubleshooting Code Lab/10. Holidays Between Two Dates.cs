using System;
using System.Globalization;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            GetHolidays();
        }

        public static void GetHolidays()
        {
            DateTime startDate;
            DateTime endDate;
            try
            {
                string format = "d.M.yyyy";

                startDate = DateTime.ParseExact(Console.ReadLine().Trim(), format, CultureInfo.InvariantCulture);
                endDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
                int holidaysCount = 0;
                var date = startDate;
                while (date <= endDate)
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        holidaysCount++;
                    }
                    date = date.AddDays(1);
                }
                Console.WriteLine(holidaysCount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Not valid date!");
            }
        }
    }
}
