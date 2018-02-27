using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            List<long> list = allPrimes(long.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            int counter = 0;
            foreach (long num in list)
            {
                if (counter < list.Count - 1)
                {
                    Console.Write(num + ", ");
                }
                else
                {
                    Console.WriteLine(num);
                }
                counter++;
            }
        }

        public static List<long> allPrimes(long start, long end) 
        {
            List<long> list = new List<long>();
            for (long i = start; i <= end; ++i)
            {
                if (IsItPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static bool IsItPrime(long number)
        {
            if (number < 2)
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
