using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < n; ++i)
            {
                string number = Console.ReadLine();
                string symbols = GetSymbols(number);
                text.Append(symbols[number.Length - 1]);
            }
            Console.WriteLine(text);
        }
        public static string GetSymbols(string number)
        {
            char symbol = number[0];
            switch (symbol)
            {
                case '0':
                    return " ";
                case '2':
                    return "abc";
                case '3':
                    return "def";
                case '4':
                    return "ghi";
                case '5':
                    return "jkl";
                case '6':
                    return "mno";
                case '7':
                    return "pqrs";
                case '8':
                    return "tuv";
                case '9':
                    return "wxyz";
            }
            return "";
        }
    }
}