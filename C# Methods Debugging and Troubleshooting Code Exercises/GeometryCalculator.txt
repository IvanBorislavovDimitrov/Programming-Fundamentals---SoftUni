using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine().ToLower();
            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{side * height / 2:F2}");
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{side * side:F2}");
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{width * height:F2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{radius * radius * Math.PI:F2}");
                    break;
            }
        }
    }
}
