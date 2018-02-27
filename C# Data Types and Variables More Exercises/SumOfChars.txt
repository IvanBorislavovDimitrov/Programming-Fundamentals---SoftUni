using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0L;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                char a = char.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
