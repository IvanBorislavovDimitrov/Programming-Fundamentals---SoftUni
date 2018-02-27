using System;
using System.Numerics;


namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CalculateFibonacci(BigInteger.Parse(Console.ReadLine())));
        }
        public static BigInteger CalculateFibonacci(BigInteger n)
        {
            if (n == 0)
            {
                return 1;
            }
            BigInteger currentNumber = 1;
            BigInteger prevNumber = 1;
            for (int i = 0; i < n; ++i)
            {
                BigInteger nextNumber = currentNumber + prevNumber;
                prevNumber = currentNumber;
                currentNumber = nextNumber;
            }
            return prevNumber;
        }
    }
}
