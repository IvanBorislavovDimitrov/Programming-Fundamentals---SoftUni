using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRes = int.Parse(Console.ReadLine());
            int secondRes = int.Parse(Console.ReadLine());
            long allPixels = firstRes * secondRes;
            Console.WriteLine($"{firstRes}x{secondRes} => {Math.Round((allPixels / 1000000.0), 1)}MP");
        }
    }
}