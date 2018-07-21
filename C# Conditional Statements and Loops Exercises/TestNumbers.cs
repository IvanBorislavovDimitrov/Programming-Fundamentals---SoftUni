using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            long sum = 0;
            int countOfCombinations = 0;
            for (int i = n; i >= 1; --i)
            {
                for (int j = 1; j <= m; ++j)
                {
                    sum += (3 * i * j);
                    countOfCombinations++;
                    if (sum >= max)
                    {
                        Console.WriteLine(countOfCombinations + " combinations");
                        Console.WriteLine($"Sum: {sum} >= {max}");
                        return;
                    }
                }
            }
            Console.WriteLine(countOfCombinations + " combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
