using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = m; i >= n; --i)
            {
                for (int j = m; j >= n; --j)
                {
                    count++;
                    if ((i + j) == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {i + j}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicalNumber}");
        }
    }
}
