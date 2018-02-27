using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = GetLineLength(x1, y1, x2, y2);
            double secondLine = GetLineLength(x3, y3, x4, y4);
            if (firstLine > secondLine)
            {
                double firstRadius = CalculateRadius(x1, y1);
                double secondRadius = CalculateRadius(x2, y2);
                if (firstRadius <= secondRadius)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (firstLine < secondLine)
            {
                double firstRadius = CalculateRadius(x3, y3);
                double secondRadius = CalculateRadius(x4, y4);
                if (firstRadius <= secondRadius)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else 
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
              
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        public static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double x = Math.Abs(x2 - x1);
            double y = Math.Abs(y2 - y1);
            return Math.Sqrt(x * x + y * y);
        }

        public static double CalculateRadius(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
