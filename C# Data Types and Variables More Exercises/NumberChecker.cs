using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long number;
            if (long.TryParse(input, out number))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
