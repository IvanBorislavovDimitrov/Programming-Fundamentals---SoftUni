using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long maxCountedNumber = numbers[0];
            int currentCountOfNumber = 0;
            int bestCountOfNumber = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                currentCountOfNumber = 0;
                 for (int j = 0; j < numbers.Length; ++j)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCountOfNumber++;
                        if (currentCountOfNumber > bestCountOfNumber)
                        {
                            bestCountOfNumber = currentCountOfNumber;
                            maxCountedNumber = numbers[i];
                        }
                    }
                }
            }
            Console.WriteLine(maxCountedNumber);
        }
    }
}
