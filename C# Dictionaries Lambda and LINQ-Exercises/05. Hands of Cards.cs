using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> players = new Dictionary<string, int>();
            Dictionary<string, List<string>> cardsOfEveryPlayer = new Dictionary<string, List<string>>();
            string line;
            while ((line = Console.ReadLine()) != "JOKER")
            {
                string[] playerAndCards = line.Split(new[]{ ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string nameOfPlayer = playerAndCards[0].Trim();
                if (!players.ContainsKey(nameOfPlayer))
                {
                    cardsOfEveryPlayer.Add(nameOfPlayer, new List<string>());
                    int sumOfCards = CalculateSumOfCards(playerAndCards, cardsOfEveryPlayer);
                    players.Add(nameOfPlayer, sumOfCards);
                }
                else
                {
                    int sumOfCards = CalculateSumOfCards(playerAndCards, cardsOfEveryPlayer);
                    players[nameOfPlayer] += sumOfCards;
                }
            }
            foreach (var name in players.Keys)
            {
                Console.WriteLine($"{name}: {players[name]}");
            }
        }

        private static int CalculateSumOfCards(string[] playersAndCards, Dictionary<string, List<string>> cardsOfEveryPlayer)
        {
            int sum = 0;
            for (int i = 1; i < playersAndCards.Length; i++)
            {
                string nameOfPlayer = playersAndCards[0].Trim();
                if (!cardsOfEveryPlayer[nameOfPlayer].Contains(playersAndCards[i].Trim()))
                {
                    cardsOfEveryPlayer[nameOfPlayer].Add(playersAndCards[i].Trim());
                    string card = playersAndCards[i].Trim().Substring(0, playersAndCards[i].Length - 2);
                    char type = playersAndCards[i][playersAndCards[i].Length - 1];
                    int multiply = 1;
                    switch (type)
                    {
                        case 'S':
                            multiply = 4;
                            break;
                        case 'H':
                            multiply = 3;
                            break;
                        case 'D':
                            multiply = 2;
                            break;
                    }
                    switch (card)
                    {
                        case "2":
                            sum += 2 * multiply;
                            break;
                        case "3":
                            sum += 3 * multiply;
                            break;
                        case "4":
                            sum += 4 * multiply;
                            break;
                        case "5":
                            sum += 5 * multiply;
                            break;
                        case "6":
                            sum += 6 * multiply;
                            break;
                        case "7":
                            sum += 7 * multiply;
                            break;
                        case "8":
                            sum += 8 * multiply;
                            break;
                        case "9":
                            sum += 9 * multiply;
                            break;
                        case "10":
                            sum += 10 * multiply;
                            break;
                        case "J":
                            sum += 11 * multiply;
                            break;
                        case "Q":
                            sum += 12 * multiply;
                            break;
                        case "K":
                            sum += 13 * multiply;
                            break;
                        case "A":
                            sum += 14 * multiply;
                            break;
                    }
                }
            }
            return sum;
        }
    }
}