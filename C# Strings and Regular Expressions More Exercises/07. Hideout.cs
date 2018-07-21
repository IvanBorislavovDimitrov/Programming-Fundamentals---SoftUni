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
            string text = Console.ReadLine();
            while (true)
            {
                string[] line = Console.ReadLine().Split(' ');
                char searchedSymbol = char.Parse(line[0]);
                int count = int.Parse(line[1]);

                string searchedWord = new string(searchedSymbol, count);
                int indexOfHideout = text.IndexOf(searchedWord);
                if (indexOfHideout != -1)
                {
                    int plus = 0;
                    //for (int i = indexOfHideout; i < text.Length; i++)
                    //{
                    //    if (text[indexOfHideout] == text[i])
                    //    {
                    //        plus++;

                    //    }
                    //    else
                    //    {
                    //        break;
                    //    }
                    //}
                    while (indexOfHideout + plus <= text.Length - 1 && text[indexOfHideout] == text[indexOfHideout + plus])
                    {
                        plus++;
                    }
                    Console.WriteLine($"Hideout found at index {indexOfHideout} and it is with size {plus}!");
                    break;
                }
            }
        }
    }
}