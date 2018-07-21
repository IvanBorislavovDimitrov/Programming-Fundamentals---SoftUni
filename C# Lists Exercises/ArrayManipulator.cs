using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main()
        {
            List<long> numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            string line;
            while ((line = Console.ReadLine()) != "print")
            {
                string[] commands = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "add":
                        int index = int.Parse(commands[1]);
                        long elementToAdd = long.Parse(commands[2]);
                        numbers.Insert(index, elementToAdd);
                        break;
                    case "addMany":
                        index = int.Parse(commands[1]);
                        long[] arrayToAdd = commands.Skip(2).Select(long.Parse).ToArray();
                        numbers.InsertRange(index, arrayToAdd);
                        break;
                    case "contains":
                        long element = long.Parse(commands[1]);
                        Console.WriteLine(numbers.IndexOf(element));
                        break;
                    case "remove":
                        index = int.Parse(commands[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "shift":
                        int positions = int.Parse(commands[1]);
                        for(int i = 0; i < positions; i++)
                        {
                            long lastElement = numbers[0];
                            for(int j = 0; j < numbers.Count -1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = lastElement;
                        }
                        break;
                    case "sumPairs":
                        numbers = SumPairs(numbers);
                        break;
                }
            }
            if (numbers.Count != 0)
            {
                Console.WriteLine("[" + string.Join(", ", numbers) + "]");
            }
        }

        static List<long> SumPairs(List<long> numbers)
        {
            List<long> newNumbers = new List<long>();
            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                newNumbers.Add(numbers[i] + numbers[i + 1]);
            }
            if (numbers.Count % 2 != 0)
            {
                newNumbers.Add(numbers[numbers.Count - 1]);
            }
            return newNumbers;
        }

    }
}
