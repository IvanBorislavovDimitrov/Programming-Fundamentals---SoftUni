using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            numbers.RemoveAll(x => x % 2 != 0);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > GetSumOfReminigNumbers(numbers[i], numbers))
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static double GetSumOfReminigNumbers(long element, List<long> numbers)
        {
            double sum = 0;
            int counter = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != element)
                {
                    sum += numbers[i];
                    counter++;
                }
            }
            return sum / counter;
        }
    }
}