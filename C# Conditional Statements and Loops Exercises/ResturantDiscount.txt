using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            if (countOfPeople <= 0 || countOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            string package = Console.ReadLine().ToLower();
            double priceForPackage = 0;
            int discountForPackage = 0;
            switch (package)
            {
                case "normal":
                    discountForPackage = 5;
                    priceForPackage = 500;
                    break;
                case "gold":
                    discountForPackage = 10;
                    priceForPackage = 750;
                    break;
                case "platinum":
                    discountForPackage = 15;
                    priceForPackage = 1000;
                    break;
            }
            double totalPrice = 0;
            double pricePerPerson = 0;
            string hall = "";
            if (countOfPeople <= 50)
            {
                totalPrice += priceForPackage + 2500;
                totalPrice *= ((100 - discountForPackage) / 100.0); // price after discount
                pricePerPerson = totalPrice / countOfPeople;
                hall = "Small Hall";
            }
            else if (countOfPeople <= 100)
            {
                totalPrice += priceForPackage + 5000;
                totalPrice *= ((100 - discountForPackage) / 100.0); // price after discount
                pricePerPerson = totalPrice / countOfPeople;
                hall = "Terrace";
            }
            else if (countOfPeople < 120)
            {
                totalPrice += priceForPackage + 7500;
                totalPrice *= ((100 - discountForPackage) / 100.0); // price after discount
                pricePerPerson = totalPrice / countOfPeople;
                hall = "Great Hall";
            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
