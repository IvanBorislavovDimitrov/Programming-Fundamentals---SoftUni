using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
                int num = i;
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                bool isSpecial = sum == 5 ? true : sum == 7 ? true : sum == 11 ? true : false;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
