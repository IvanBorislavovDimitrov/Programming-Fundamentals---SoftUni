using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            isItPositive(int.Parse(Console.ReadLine()));
        }
        public static void isItPositive(double number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
