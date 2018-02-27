using System;
using System.Linq;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long minElement = numbers[0];
            long maxElement = numbers[0];
            long sumOfElements = numbers[0];
            double average = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                average += numbers[i];
                if (minElement > numbers[i])
                {
                    minElement = numbers[i];
                }
                if (maxElement < numbers[i])
                {
                    maxElement = numbers[i];
                }
            }

            Console.WriteLine($"Min = {minElement}");
            Console.WriteLine($"Max = {maxElement}");
            Console.WriteLine($"Sum = {average}");
            Console.WriteLine($"Average = {(double)average / numbers.Length}");
        }
    }
}
