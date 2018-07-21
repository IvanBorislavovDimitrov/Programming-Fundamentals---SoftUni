using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            int bestStart = 0;
            int bestLen = 1;
            int currentStart = 0;
            int currentLen = 1;

            for (int i = 1; i < numbers.Count; ++i)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLen++;
                    if (currentLen > bestLen)
                    {
                        bestLen = currentLen;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentLen = 1;
                    currentStart = i;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; ++i)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}   