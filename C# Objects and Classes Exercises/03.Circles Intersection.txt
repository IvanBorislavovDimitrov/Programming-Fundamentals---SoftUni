using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class CenterPoint
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
    }
    class Circle
    {
        public CenterPoint CenterPoint { get; set; }
        public double Radius { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            double[] coordinates = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            circle1.CenterPoint = new CenterPoint();
            circle1.CenterPoint.X1 = coordinates[0];
            circle1.CenterPoint.Y1 = coordinates[1];
            circle1.Radius = coordinates[2];
            coordinates = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            
            circle2.CenterPoint = new CenterPoint();
            circle2.CenterPoint.X1 = coordinates[0];
            circle2.CenterPoint.Y1 = coordinates[1];
            circle2.Radius = coordinates[2];
            Console.WriteLine(AreCirclesIntersect(circle1, circle2) ? "Yes" : "No");
        }

        public static bool AreCirclesIntersect(Circle circle1, Circle circle2)
        {
            double a = Math.Abs(circle1.CenterPoint.X1 - circle2.CenterPoint.X1);
            double b = Math.Abs(circle1.CenterPoint.Y1 - circle2.CenterPoint.Y1);
            double c = Math.Sqrt(a * a + b * b);

            if (c <= (circle1.Radius + circle2.Radius))
            {
                return true;
            }
            return false;
        }
    }
}