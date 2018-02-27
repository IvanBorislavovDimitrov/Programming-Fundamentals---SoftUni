using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int first = Math.Min(n1, n2);
            int second = Math.Max(n1, n2);
            for (int i = first; i <= second; ++i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
