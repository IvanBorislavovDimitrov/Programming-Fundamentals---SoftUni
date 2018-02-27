using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            GetWordsStartingWithLetterPWithGivenLength(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        public static void GetWordsStartingWithLetterPWithGivenLength(string text, int size)
        {
            int indexOfLetterP = text.IndexOf('p');
            bool flag = true;
            while (indexOfLetterP != -1)
            {
                Console.WriteLine(GetWord(text, indexOfLetterP, size));
                flag = false;
                if (indexOfLetterP + size >= text.Length)
                {
                    break;
                }
                indexOfLetterP = text.IndexOf('p', indexOfLetterP + size + 1);
            }
            if (flag)
            {
                Console.WriteLine("no");
            }
        }
        public static string GetWord(string text, int startIndex, int size)
        {
            if (size >= text.Length - startIndex)
            {
                return text.Substring(startIndex);
            }
            return text.Substring(startIndex, size + 1);
        }
    }
}
