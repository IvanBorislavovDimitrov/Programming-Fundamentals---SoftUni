using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (char i = (char)a; i <= b; ++i)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
