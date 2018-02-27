using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Program
{
    class Coordinates
    {
        public double X1 { get; set; }

        public double Y1 { get; set; }

        public double X2 { get; set; }

        public double Y2 { get; set; }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates coordinates = new Coordinates();
            double[] firstTwoCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondTwoCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            coordinates.X1 = firstTwoCoordinates[0];
            coordinates.Y1 = firstTwoCoordinates[1];
            coordinates.X2 = secondTwoCoordinates[0];
            coordinates.Y2 = secondTwoCoordinates[1];

            double a = Math.Abs(coordinates.X1 - coordinates.X2);
            double b = Math.Abs(coordinates.Y1 - coordinates.Y2);
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"{c:F3}");

        }
    }
}