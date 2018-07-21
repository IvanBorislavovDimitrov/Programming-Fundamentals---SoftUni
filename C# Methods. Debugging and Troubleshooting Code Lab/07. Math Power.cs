using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Power(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"{num}");
        }
        public static double Power(double number, double power)
        {
            double num = number;
            for (int i = 1; i < power; ++i)
            {
                number *= num;
            }
            return number;
        }
    }
}
