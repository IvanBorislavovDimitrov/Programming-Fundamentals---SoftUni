using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            int countOfLines = int.Parse(Console.ReadLine());
            List<string> allLines = new List<string>();
            for (int i = 0; i < countOfLines; ++i)
            {
                StringBuilder buffer = new StringBuilder();
                string line = Console.ReadLine();
                long[] numbers = GetNumbersFromTheLine(line);
                for (int j = 0; j < numbers.Length; ++j)
                {
                    if (numbers[j] >= 0)
                    {
                        buffer.Append(numbers[j]);
                        buffer.Append(" ");
                    }
                    else
                    {
                        if (j + 1 < numbers.Length)
                        {
                            long num = numbers[j] + numbers[j + 1];
                            if (num >= 0)
                            {
                                buffer.Append(num);
                                buffer.Append(" ");
                            }
                        }
                        j += 1;
                    }
                }
                if (buffer.Length == 0)
                {
                    buffer.Append("(empty)");
                }
                allLines.Add(buffer.ToString());
            }
            for (int i = 0; i < allLines.Count; ++i)
            {
                Console.WriteLine(allLines[i]);
            }
        }
        public static long[] GetNumbersFromTheLine(string line)
        {
            char[] regex = @" +".ToCharArray();
            string[] numbersInStringArray = line.Split(regex, StringSplitOptions.RemoveEmptyEntries);
            long[] numbers = new long[numbersInStringArray.Length];
            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = long.Parse(numbersInStringArray[i]);
            }
            return numbers;

        }
    }
}
