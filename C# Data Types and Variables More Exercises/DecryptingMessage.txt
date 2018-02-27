using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int plus = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; ++i)
            {
                char input = Console.ReadLine()[0];
                int ch = input + plus;
                sb.Append((char)ch);
            }
            Console.WriteLine(sb);
        }
    }
}
