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
            string input = Console.ReadLine();
            string output = string.Empty;
            int number = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    number += int.Parse(input[i + 1].ToString());
                }
                else if (number > 0)
                {
                    number--;
                    continue;
                }
                 output += input[i];
            }

            Console.WriteLine(output);
        }
    }
}