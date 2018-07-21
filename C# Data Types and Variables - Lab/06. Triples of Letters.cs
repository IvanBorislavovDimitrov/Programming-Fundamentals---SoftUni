using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int first = 'a'; first < 'a' + n; ++first)
            {
                for (int second = 'a'; second < 'a' + n; ++second)
                {
                    for (int third = 'a'; third < 'a' + n; ++third)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append((char)first);
                        sb.Append((char)second);
                        sb.Append((char)third);
                        Console.WriteLine(sb);
                    }
                }
            }
        }
    }
}
