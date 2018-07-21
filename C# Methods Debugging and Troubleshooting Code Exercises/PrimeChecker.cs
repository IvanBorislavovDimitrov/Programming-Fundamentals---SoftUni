using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(IsItPrime(long.Parse(Console.ReadLine())));
        }
        public static bool IsItPrime(long number)
        {
            if (number <= 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
