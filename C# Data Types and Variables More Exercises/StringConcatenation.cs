using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimetre = Console.ReadLine();
            string evenOrOdd = Console.ReadLine().ToLower();
            int n = int.Parse(Console.ReadLine());
            StringBuilder buffer = new StringBuilder();
            for (int i = 1; i <= n; ++i)
            {
                string word = Console.ReadLine();
                if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        buffer.Append(word);
                        buffer.Append(delimetre);
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    if (i % 2 != 0)
                    {
                        buffer.Append(word);
                        buffer.Append(delimetre);
                    }
                }
            }
            Console.WriteLine(buffer.ToString().Substring(0, buffer.Length - 1));
        }
    }
}
