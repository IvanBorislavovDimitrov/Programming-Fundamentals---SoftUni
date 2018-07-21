using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioRoom = 0;
            double doubleRoom = 0;
            double suiteRoom = 0;
            switch (month)
            {
                case "May":
                case "October":
                    studioRoom = 50 * nights;
                    doubleRoom = 65 * nights;
                    suiteRoom = 75 * nights;
                    break;
                case "June":
                case "September":
                    studioRoom = 60 * nights;
                    doubleRoom = 72 * nights;
                    suiteRoom = 82 * nights;
                    break;
                case "July":
                case "August":
                case "December":
                    studioRoom = 68 * nights;
                    doubleRoom = 77 * nights;
                    suiteRoom = 89 * nights;
                    break;  
            }
            if (nights > 7 && (month == "May" || month == "October"))
            {
                studioRoom *= 0.95;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                doubleRoom *= 0.9;
            }
            else if (nights > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suiteRoom *= 0.85;
            }
            else if (nights > 7 && (month == "September" || month == "October"))
            {
               if (month == "September")
                {
                    studioRoom -= 60;
                }
               else
                {
                    studioRoom -= 50;
                }
            }
            Console.WriteLine($"Studio: {studioRoom:F2} lv.");
            Console.WriteLine($"Double: {doubleRoom:F2} lv.");
            Console.WriteLine($"Suite: {suiteRoom   :F2} lv.");
        }
    }
}
