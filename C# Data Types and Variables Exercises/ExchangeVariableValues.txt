using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}