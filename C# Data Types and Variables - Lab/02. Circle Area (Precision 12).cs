using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = radius * radius * Math.PI;
            Console.WriteLine($"{area:F12}");
        }
    }
}
