using System;
using System.Linq;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                string currentCommand = Console.ReadLine();
                if (currentCommand.Contains("Distinct"))
                {
                    words = Distinct(words);
                }
                else if (currentCommand.Contains("Reverse"))
                {
                    words = Reverse(words);
                }
                else if (currentCommand.Contains("Replace"))
                {
                    string[] commands = currentCommand.Split(' ');
                    int currentNumber = int.Parse(commands[1]);

                    Replace(words, currentNumber, commands[2]);
                }
            }
            Console.WriteLine(string.Join(", ", words));
        }

        static void Replace(string[] words, int index, string text)
        {
            words[index] = text;
        }

        static string[] Reverse(string[] words)
        {
            string[] temp = new string[words.Length];
            int index = 0;
            for (int i = words.Length - 1; i >= 0; --i)
            {
                temp[index++] = words[i];
            }
            return temp;
        }

        static string[] Distinct(string[] words)
        {

            for (int i = 0; i < words.Length - 1; ++i)
            {
                bool goBackOneElement = false;
                for (int j = i + 1; j < words.Length; ++j)
                {
                    if (words[i] == words[j])
                    {
                        RightShift(words, j);
                        string[] temp = new string[words.Length - 1];
                        Array.Copy(words, temp, words.Length - 1);
                        words = temp;
                        goBackOneElement = true;
                    }
                }
                if (goBackOneElement)
                {
                    --i;
                }
            }
            return words;
        }

        static void RightShift(string[] words, int startIndex)
        {
            for (int i = startIndex; i < words.Length - 1; ++i)
            {
                string swap = words[i];
                words[i] = words[i + 1];
                words[i + 1] = swap;
            }
        }
    }
}
