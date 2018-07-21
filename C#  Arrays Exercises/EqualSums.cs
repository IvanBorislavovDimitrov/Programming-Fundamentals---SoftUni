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
            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            bool flag = false;
            for (int i = 0; i < numbers.Length; ++i)
            {
                long leftSum = 0;
                long rightSum = 0;

                for (int k = 0; k < i; ++k)
                {
                    leftSum += numbers[k];
                }

                for (int k = i + 1; k < numbers.Length; ++k)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}
