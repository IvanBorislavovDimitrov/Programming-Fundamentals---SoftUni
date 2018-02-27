using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int searchedNumber = Int32.Parse(Console.ReadLine());
            int countOfPairs = 0;

            for (int i = 0; i < numbers.Length - 1; ++i)
            {
                for (int j = i + 1; j < numbers.Length; ++j)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == searchedNumber)
                    {
                        countOfPairs++;
                    }
                }
            }
            Console.WriteLine(countOfPairs);
        }
    }
}
