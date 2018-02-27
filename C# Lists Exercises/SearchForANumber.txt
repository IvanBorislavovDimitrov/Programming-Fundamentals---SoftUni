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
            int[] numbersForOperations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<long> neededNumbers = GetNeededList(numbers, numbersForOperations[0]);
            RemoveGivenElementFromTheList(neededNumbers, numbersForOperations[1]);
            if (IsThereSuchElementInTheList(neededNumbers, numbersForOperations[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
         }

        static bool IsThereSuchElementInTheList(List<long> numbers, int searchedElement)
        {
            for (int i = 0; i < numbers.Count; ++i)
            {
                if (numbers[i] == searchedElement)
                {
                    return true;
                }
            }
            return false;
        }

        static void RemoveGivenElementFromTheList(List<long> numbers, int countOfElementsToRemove)
        {
            for (int i = 0; i < countOfElementsToRemove; ++i)
            {
                numbers.Remove(numbers[0]);
                if (numbers.Count == 0)
                {
                    break;
                }
            }
        }

        static List<long> GetNeededList(List<long> numbers, int count)
        {
            List<long> neededNumbers = new List<long>();
            for (int i = 0; i < count; ++i)
            {
                neededNumbers.Add(numbers[i]);
            }
            return neededNumbers;
        }
    }
}