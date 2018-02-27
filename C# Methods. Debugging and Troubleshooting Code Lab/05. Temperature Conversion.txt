using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Convert(double.Parse(Console.ReadLine()));
            Console.WriteLine($"{num:F2}");
        }
        public static double Convert(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
    }
}
