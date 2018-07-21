using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine().ToLower();
            double value = double.Parse(Console.ReadLine());
            double convertedValue = 0;
            string convertedUnit = "";
            switch (unit)
            {
                case "miles":
                    convertedValue = value * 1.6;
                    convertedUnit = "kilometers";
                    break;
                case "inches":
                    convertedUnit = "centimeters";
                    convertedValue = value * 2.54;
                    break;
                case "feet":
                    convertedUnit = "centimeters";
                    convertedValue = value * 30;
                    break;
                case "yards":
                    convertedUnit = "meters";
                    convertedValue = value * 0.91;
                    break;
                case "gallons":
                    convertedUnit = "liters";
                    convertedValue = value * 3.8;
                    break;
            }
            Console.WriteLine($"{value} {unit} = {convertedValue:F2} {convertedUnit}");
        }
    }
}
