using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}