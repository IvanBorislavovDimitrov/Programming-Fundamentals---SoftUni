using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            
            int number = numbers[0];
            int count = 1;
            int maxCount = 1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}