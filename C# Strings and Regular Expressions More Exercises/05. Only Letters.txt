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
            List<char> line = Console.ReadLine().ToList();
            for (int i = 0; i < line.Count - 1; i++)
            {
                bool isThereLetter = false;
                for (int j = i + 1; j < line.Count; j++)
                {
                    if (char.IsLetter(line[j]))
                    {
                        isThereLetter = true;
                        break;
                    }
                }
                if (char.IsDigit(line[i]) && char.IsLetter(line[i + 1]))
                {
                    line[i] = line[i + 1];
                }
                else if (char.IsDigit(line[i]) && isThereLetter)
                {
                    line.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", line));
        }
    }
}