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
            string line = Console.ReadLine();
            long detonationNumber = long.Parse(line.Split(' ')[0]);
            int power = int.Parse(line.Split(' ')[1]);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == detonationNumber)
                {
                    int mostLeftIndex = i - power;
                    if (mostLeftIndex < 0)
                    {
                        mostLeftIndex = 0;
                    }
                    int mostRightIndex = i + power;
                    if (mostRightIndex >= numbers.Count)
                    {
                        mostRightIndex = numbers.Count - 1;
                    }
                    for (int j = 0; j < mostRightIndex - mostLeftIndex + 1; j++)
                    {
                        numbers.RemoveAt(mostLeftIndex);
                    }
                    --i;
                }

            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
