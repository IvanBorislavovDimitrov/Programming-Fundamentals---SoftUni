using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyNumbers(number));
        }

        public static long MultiplyNumbers(long number)
        {
            long sumOfOdd = 0;
            long sumOfEven = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    sumOfEven += number % 10;
                }
                else
                {
                    sumOfOdd += number % 10;
                }
                number /= 10;
            }
            return sumOfOdd * sumOfEven;
        }
    }
}
