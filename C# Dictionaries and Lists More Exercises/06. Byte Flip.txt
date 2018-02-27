using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersInHexadecimalFormat = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            RemoveElementsWithLengthDifferentOfTwo(numbersInHexadecimalFormat);
            ReverseDigits(numbersInHexadecimalFormat);
            numbersInHexadecimalFormat.Reverse();
            int[] numberInDecimalFormat = new int[numbersInHexadecimalFormat.Count];
            for (int i = 0; i < numberInDecimalFormat.Length; i++)
            {
                numberInDecimalFormat[i] = Convert.ToInt32(numbersInHexadecimalFormat[i], 16);
            }
            for (int i = 0; i < numberInDecimalFormat.Length; i++)
            {
                Console.Write((char)numberInDecimalFormat[i]);
            }
        }

        private static void ReverseDigits(List<string> numbersInHexadecimalFormat)
        {
            for (int i = 0; i < numbersInHexadecimalFormat.Count; i++)
            {
                numbersInHexadecimalFormat[i] = ReverseString(numbersInHexadecimalFormat[i]);
            }
            
        }

        private static string ReverseString(string stringToReverse)
        {
            string reversedString = string.Empty;
            for (int i = 0; i < stringToReverse.Length; i++)
            {
                reversedString += stringToReverse[stringToReverse.Length - 1 - i];
            }
            return reversedString;
        }

        private static void RemoveElementsWithLengthDifferentOfTwo(List<string> numbersInHexadecimalFormat)
        {
            numbersInHexadecimalFormat.RemoveAll(x => x.Length != 2);
        }
    }
}