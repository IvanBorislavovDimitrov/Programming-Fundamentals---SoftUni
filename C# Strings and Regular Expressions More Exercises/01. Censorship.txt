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
            string replaceWord = Console.ReadLine();
            string text = Console.ReadLine();
            text = text.Replace(replaceWord, new String('*', replaceWord.Length));
            Console.WriteLine(text);
        }
    }
}