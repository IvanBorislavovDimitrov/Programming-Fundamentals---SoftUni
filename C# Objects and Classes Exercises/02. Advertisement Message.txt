using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            int countOfAdvertisments = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfAdvertisments; i++)
            {
                Console.WriteLine(MakeAdvertisment());
            }
        }

        static string MakeAdvertisment()
        {
            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            for (int i = 0; i < 10000000; i++)
            {
                if (i == 10000)
                {
                }
            }
            Random random = new Random();
            int indexForPhrases = random.Next(0, phrases.Length);
            int indexForEvents = random.Next(0, events.Length);
            int indexForAuthors = random.Next(0, authors.Length);
            int indexForCities = random.Next(0, cities.Length);
            
            return $"{phrases[indexForPhrases]} {events[indexForEvents]} {authors[indexForAuthors]} " +
                                  $"{cities[indexForCities]}";
        }
    }
}