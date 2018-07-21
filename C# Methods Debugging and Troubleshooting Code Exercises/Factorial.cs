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
            Console.WriteLine(factorial(number));
        }
        public static BigInteger factorial(BigInteger number)
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
