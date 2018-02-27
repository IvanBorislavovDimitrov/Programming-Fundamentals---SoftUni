using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Odd" && line != "Even")
            {
                string[] commands = line.Split(' ');
                switch (commands[0])
                {
                    case "Delete":
                        Delete(numbers, long.Parse(commands[1]));
                        break;
                    case "Insert":
                        numbers = Insert(numbers, long.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                }
            }

            switch (line)
            {
                case "Odd":
                    PrintOddElements(numbers);
                    break;
                case "Even":
                    PrintEvenElements(numbers);
                    break;
            }
        }

        static void PrintEvenElements(List<long> numbers)
        {
            for (int i = 0; i < numbers.Count; ++i)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void PrintOddElements(List<long> numbers)
        {
            for (int i = 0; i < numbers.Count; ++i)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static List<long> Insert(List<long> numbers, long elementToInsert, int position)
        {
            List<long> tempList = new List<long>();
            int countOfNumbers = 0;
            for (int i = 0; i < numbers.Count + 1; ++i)
            {
                if (position == i)
                {
                    tempList.Add(elementToInsert);
                }
                else
                {
                    tempList.Add(numbers[countOfNumbers++]);
                }
            }
            return tempList;
        }

        static void Delete(List<long> numbers, long elementToRemove)
        {
            for (int i = 0; i < numbers.Count; ++i)
            {
                bool isSomethingDeleted = false;
                if (numbers[i] == elementToRemove)
                {
                    numbers.Remove(elementToRemove);
                    isSomethingDeleted = true;
                }
                if (isSomethingDeleted)
                {
                    --i;
                }
            }
        }
    }
}