using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            for (int i = 1; i <= number; ++i)
            {
                if (IsItPolindrome(i) && IsSumOfDiggitsEqualToSeven(i) && DoesItHaveEvenDiggit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool DoesItHaveEvenDiggit(long number)
        {
            long numberI = number;
            while (numberI != 0)
            {
                long reminder = numberI % 10;
                if (reminder % 2 == 0)
                {
                    return true;
                }
                numberI /= 10;
            }
            return false;
        }

        public static bool IsSumOfDiggitsEqualToSeven(long number)
        {
            long numberI = number;
            long sumOfNumbers = 0;
            while (numberI != 0)
            {
                sumOfNumbers += numberI % 10;
                numberI /= 10;
            }
            if (sumOfNumbers % 7 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsItPolindrome(long number)
        {
            long numberI = number;
            long storeNumber = number;
            long newNumber = 0;
            while (numberI != 0)
            {
                newNumber *= 10;
                newNumber += numberI % 10;
                numberI /= 10;
            }
            if (newNumber == storeNumber)
            {
                return true;
            }
            return false;
        }
    }
}
