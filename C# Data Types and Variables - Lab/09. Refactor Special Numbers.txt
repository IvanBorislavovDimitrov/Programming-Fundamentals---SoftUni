using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number  % 10;
                    number /= 10;
                }
                bool isSpecial = sum == 5 ? true : sum == 7 ? true : sum == 11 ? true : false;
                 Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}