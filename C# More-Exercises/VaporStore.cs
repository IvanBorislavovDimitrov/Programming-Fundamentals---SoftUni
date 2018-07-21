using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfGame;
            double startMoney = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            while ((nameOfGame = Console.ReadLine()) != "Game Time")
            {
                double priceOfGame = GetGamePrice(nameOfGame);
                if (priceOfGame == 0)
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                if (startMoney < priceOfGame)
                {
                    Console.WriteLine("To Expensive");
                    continue;
                }
                if (startMoney >= priceOfGame)
                {
                    Console.WriteLine("Bought " + nameOfGame);
                    startMoney -= priceOfGame;
                    totalSpent += priceOfGame;
                }
                if (startMoney == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${totalSpent}. Remaining: ${startMoney:F2}");
        }
        public static double GetGamePrice(string nameOfGame)
        {
            switch (nameOfGame)
            {
                case "OutFall 4":
                    return 39.99;
                case "CS: OG":
                    return 15.99;
                case "Zplinter Zell":
                    return 19.99;
                case "Honored 2":
                    return 59.99;
                case "RoverWatch":
                    return 29.99;
                case "RoverWatch Origins Edition":
                    return 39.99;
            }
            return 0;
        }
    }
}
