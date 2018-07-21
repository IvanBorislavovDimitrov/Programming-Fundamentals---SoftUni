using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Reverse(Console.ReadLine());
        }
        public static void Reverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; ++i)
            {
                sb.Append(str[str.Length - 1 - i]);
            }
            Console.WriteLine(sb);
        }
    }
}
