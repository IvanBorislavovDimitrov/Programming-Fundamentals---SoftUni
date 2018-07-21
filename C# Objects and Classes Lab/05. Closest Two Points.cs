using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Point
    {
        public double X1 { get; set; }
        
        public double Y1 { get; set; }        
    }
    class Program
    {
        public static void Main()
        {
            int countOfPoints = int.Parse(Console.ReadLine());
            Point[] points = new Point[countOfPoints];
            for (int i = 0; i < countOfPoints; i++)
            {
                double[] parametres = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                points[i] = new Point
                {
                    X1 = parametres[0],
                    Y1 = parametres[1]
                };
            }
            FindClosestTwoPoints(points);
        }

        public static void FindClosestTwoPoints(Point[] points)
        {
            double closestLine = Double.MaxValue;
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double c = CalculateHypotenuse(points[i].X1, points[i].Y1, points[j].X1, points[j].Y1);
                    if (closestLine > c)
                    {
                        closestLine = c;
                        x1 = points[i].X1;
                        y1 = points[i].Y1;
                        x2 = points[j].X1;
                        y2 = points[j].Y1;
                    }
                }
            }
            Console.WriteLine($"{closestLine:F3}");
            Console.WriteLine($"({x1}, {y1})");
            Console.WriteLine($"({x2}, {y2})");
        }

        public static double CalculateHypotenuse(double x1, double y1, double x2, double y2)
        {
            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y1 - y2);
            return Math.Sqrt(x * x + y * y);
        }
    }
}
