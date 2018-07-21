using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int pos = random.Next(0, words.Length);
                string temp = words[i];
                words[i] = words[pos];
                words[pos] = temp;
            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}