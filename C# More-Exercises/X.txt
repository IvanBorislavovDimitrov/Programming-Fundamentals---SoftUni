using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int last = 0;
            for (int i = 0; i < n / 2; ++i)
            {
                Console.WriteLine($"{repeatString(" ", i)}x{repeatString(" ", n - 2 - 2 * i)}x");
                last = i;
            }
            Console.WriteLine(repeatString(" ", last + 1) + "x");
            for (int i = last; i >= 0; --i)
            {
                Console.WriteLine($"{repeatString(" ", i)}x{repeatString(" ", n - 2 - 2 * i)}x");
            }
        }
        public static string repeatString(string input, int count)
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < count; ++i)
            {
                text.Append(input);
            }
            return text.ToString();
        }
    }
}
