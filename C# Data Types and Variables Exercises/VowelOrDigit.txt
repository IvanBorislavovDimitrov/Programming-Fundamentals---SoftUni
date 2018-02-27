using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadLine()[0];
            if (Char.IsDigit(a))
            {
                Console.WriteLine("digit");
            }
            else if (a == 'a' || a == 'e' || a == 'u' || a == 'i' || a == 'o')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
