using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = TriangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"{num}");
        }
        public static double TriangleArea(double baseSide, double height)
        {
            return baseSide * height / 2.0;
        }
    }
}
