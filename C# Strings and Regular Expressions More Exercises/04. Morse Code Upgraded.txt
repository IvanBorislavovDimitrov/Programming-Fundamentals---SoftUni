using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] decryptedWords = Console.ReadLine().Split('|');
            string word = string.Empty;
            for (int i = 0; i < decryptedWords.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < decryptedWords[i].Length; j++)
                {
                    sum += decryptedWords[i][j] == '0' ? 3 : 5;
                }
                int count = 1;
                for (int j = 0; j < decryptedWords[i].Length - 1; j++)
                {
                    if (decryptedWords[i][j] == decryptedWords[i][j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        if (count > 1)
                        {
                            sum += count;
                        }
                        count = 1;
                    }
                }
                if (count > 1)
                {
                    sum += count;
                }
                Console.Write((char)sum);
            }
            Console.WriteLine();
        }
    }
}