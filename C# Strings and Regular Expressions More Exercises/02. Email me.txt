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
            string[] strs = Console.ReadLine().Split('@');
            long leftSum = GetSumOfChars(strs[0]);
            long rightSum = GetSumOfChars(strs[1]);
            long result = leftSum - rightSum;
            Console.WriteLine(result >= 0 ? "Call her!" : "She is not the one.");
        }

        static long GetSumOfChars(string input)
        {
            long sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
    }
}