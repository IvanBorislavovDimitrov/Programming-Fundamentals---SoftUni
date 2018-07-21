using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{2 * (a + b)}");
            Console.WriteLine($"{a * b}");
            Console.WriteLine($"{Math.Sqrt(a * a + b * b)}");
        }
    }
}
