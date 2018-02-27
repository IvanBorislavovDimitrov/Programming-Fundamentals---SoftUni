using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write(num + " ");
                }
                num++;
                Console.WriteLine();
            }
        }
    }
}
