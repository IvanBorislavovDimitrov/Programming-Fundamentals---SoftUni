using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int n1 = int.Parse(Console.ReadLine());
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(n1, n2));
                    break;
                case "char":
                    Console.WriteLine(GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
                    break;
                case "string":
                    Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine()));
                    break;
            }
        }
        public static string GetMax(string word1, string word2)
        {
            if (word1.CompareTo(word2) > 0)
            {
                return word1;
            }
            
             return word2;
            
        }
        public static int GetMax(int n1, int n2)
        {
            return Math.Max(n1, n2);
        }
       
        public static char GetMax(char ch1, char ch2)
        {
            if (ch1 > ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }
    }
}
