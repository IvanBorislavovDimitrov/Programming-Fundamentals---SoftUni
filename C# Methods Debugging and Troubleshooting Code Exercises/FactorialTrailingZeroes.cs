using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialNumber = Factorial(number);
            long countOfTrailingZeroes = GetCountOfTrailingZeroes(factorialNumber);
            Console.WriteLine(countOfTrailingZeroes);
        }

        public static long GetCountOfTrailingZeroes(BigInteger number)
        {
            long counter = 0;
            while ((number % 10) == 0)
            {
                counter++;
                number /= 10;
            }
            return counter;
        }

        public static BigInteger Factorial(BigInteger number)
        {
            BigInteger factorial = 1;
            for (BigInteger i = number; i >= 2; --i)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
