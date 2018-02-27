using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double widht = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (widht * length * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
