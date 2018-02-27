using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = Console.ReadLine().ToCharArray();
            for (int i = 0; i < str.Length; ++i)
            {
                Console.WriteLine($"{str[i]} -> {str[i] - 'a'}");
            }
        }
    }
}
