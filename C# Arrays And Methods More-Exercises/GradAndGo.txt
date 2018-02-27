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
            int numberToFindFromLast = int.Parse(Console.ReadLine());
            int index = LastIndexOf(numbers, numberToFindFromLast);
            if (index == -1)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }
            Console.WriteLine(GetSum(numbers, index));
        }

        static long GetSum(long[] numbers, int index)
        {
            long sum = 0;
            for (int i = 0; i < index; ++i)
            {
                sum += numbers[i];
            }
            return sum;
        }
            
        static int LastIndexOf(long[] numbers, int numberToFind)
        {
            int index = -1;
            for (int i = numbers.Length - 1; i >= 0; --i)
            {
                if (numberToFind == numbers[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
