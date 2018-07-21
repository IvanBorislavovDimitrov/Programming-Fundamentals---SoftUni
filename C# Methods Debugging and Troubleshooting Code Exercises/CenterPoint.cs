using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            GetCloserPoint(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        }

        public static void GetCloserPoint(double x1, double y1, double x2, double y2)
        {
            double radiusOfFirstPoint = CalculateRadius(x1, y1);
            double radiusOfSecondPoint = CalculateRadius(x2, y2);
            if (radiusOfFirstPoint < radiusOfSecondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (radiusOfFirstPoint > radiusOfSecondPoint)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        public static double CalculateRadius(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
