using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInHex = Console.ReadLine();
            if (numberInHex.Contains("0x"))
            {
                numberInHex = numberInHex.Substring(2);
            }
            long sum = 0;
            for (int i = numberInHex.Length - 1; i >= 0; --i)
            {
                long multiply = (long)Math.Pow(16, numberInHex.Length - 1 - i);
                sum += GetNumber(numberInHex[i]) * multiply;
            }
            Console.WriteLine(sum);
        }
        public static int GetNumber(char number)
        {
            switch (number)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
            }
            return 0;
        }
    }
}