using System;
using System.Linq;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] priceOfGoldAndJewels = Console.ReadLine().Split(' ');
            int priceOfJewels = int.Parse(priceOfGoldAndJewels[0]);
            int priceOfGold = int.Parse(priceOfGoldAndJewels[1]);
            string line;
            long allIncomes = 0;
            long allExpenses = 0;
            while ((line = Console.ReadLine()) != "Jail Time")
            {
                int currentCountOfJewels = GetCountOfJewels(line);
                int currentCountOfGold = GetCountOfGold(line);
                int currentExpenses = GetExpenses(line);
                allIncomes += currentCountOfGold * priceOfGold + currentCountOfJewels * priceOfJewels;
                allExpenses += currentExpenses;
            }
            if (allIncomes >= allExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {allIncomes - allExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {allExpenses - allIncomes}.");
            }
        }

        static int GetExpenses(string line)
        {
            int expeneses = int.Parse(line.Split(' ')[1]);
            return expeneses;
        }

        static int GetCountOfGold(string line)
        {
            string totalGoodies = line.Split(' ')[0];
            int countOfGold = 0;
            for (int i = 0; i < totalGoodies.Length; ++i)
            {
                if (totalGoodies[i] == '$')
                {
                    countOfGold++;
                }
            }
            return countOfGold;
        }

        static int GetCountOfJewels(string line)
        {
            string totalGoodies = line.Split(' ')[0];
            int countOfJewels = 0;
            for (int i = 0; i < totalGoodies.Length; ++i)
            {
                if (totalGoodies[i] == '%')
                {
                    countOfJewels++;
                }
            }
            return countOfJewels;
        }
    }
}
