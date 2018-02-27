using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main()
        {
            List<long> numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = ReverseNumber(numbers[i]);
            }
            Console.WriteLine(numbers.Sum());
        }

        public static long ReverseNumber(long number)
        {
            long reversedNumber = 0;
            while (number > 0)
            {
                reversedNumber *= 10;
                reversedNumber += number % 10;
                number /= 10;
            }
            return reversedNumber;
        }
    }
}
