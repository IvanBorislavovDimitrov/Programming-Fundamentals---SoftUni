using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string line;
            char[] regex = @" +".ToCharArray();
            List<string> allLines = new List<string>();
            while ((line = Console.ReadLine()) != "stop")
            {
                string[] commands = line.Split(regex, StringSplitOptions.RemoveEmptyEntries);
                MakeCalculation(commands, numbers);
                StringBuilder buffer = new StringBuilder();
                for (int i = 0; i < numbers.Length; ++i)
                {
                    buffer.Append(numbers[i]);
                    buffer.Append(" ");
                }
                allLines.Add(buffer.ToString());
            }
            foreach (string item in allLines)
            {
                Console.WriteLine(item);
            }
        }

        public static void MakeCalculation(string[] commands, long[] arr)
        {
            switch (commands[0])
            {
                case "add":
                    Add(arr, int.Parse(commands[1]), long.Parse(commands[2]));
                    break;
                case "subtract":
                    Subtract(arr, int.Parse(commands[1]), long.Parse(commands[2]));
                    break;
                case "multiply":
                    Multiply(arr, int.Parse(commands[1]), long.Parse(commands[2]));
                    break;
                case "rshift":
                    RightShift(arr);
                    break;
                case "lshift":
                    LeftShift(arr);
                    break;
            }
        }

        public static void LeftShift(long[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                long swap = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = swap;
            }
        }

        public static void RightShift(long[] arr)
        {
            for (int i = arr.Length - 1; i > 0; --i)
            {
                long swap = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = swap;
            }
        }

        public static void Multiply(long[] arr, int position, long number)
        {
            arr[position - 1] *= number;
        }

        public static void Subtract(long[] arr, int position, long number)
        {
            arr[position - 1] -= number;
        }

        public static void Add(long[] arr, int position, long number)
        {
            arr[position - 1] += number;
        }
    }
}
