using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> venues = new Dictionary<string, Dictionary<string, long>>();
            string line;
            while ((line = Console.ReadLine().Trim()) != "End")
            {
                if (!IsLineValid(line))
                {
                    continue;
                }
                string nameOfSinger = GetNameOfSinger(line);
                string nameOfVenue = GetNameOfVenue(line);
                long priceOfTicket = GetPriceOfTheTicket(line);
                long countOfTickets = GetCountOfTickets(line);
                long priceOfAllTickets = priceOfTicket * countOfTickets;
                if (!venues.ContainsKey(nameOfVenue))
                {
                    venues.Add(nameOfVenue, new Dictionary<string, long>());
                    venues[nameOfVenue].Add(nameOfSinger, priceOfAllTickets);
                }
                else
                {
                    if (!venues[nameOfVenue].ContainsKey(nameOfSinger))
                    {
                        venues[nameOfVenue].Add(nameOfSinger, priceOfAllTickets);
                    }
                    else
                    {
                        venues[nameOfVenue][nameOfSinger] += priceOfAllTickets;
                    }
                }
            }

            foreach (string venue in venues.Keys)
            {
                Console.WriteLine(venue);
                var sortedByPriceOfAllTicketsSingers = venues[venue].ToList();
                sortedByPriceOfAllTicketsSingers = sortedByPriceOfAllTicketsSingers.OrderByDescending(x => x.Value).ToList();
                foreach (var infoForSinger in sortedByPriceOfAllTicketsSingers)
                {
                    Console.WriteLine($"#  {infoForSinger.Key} -> {infoForSinger.Value}");
                }
            }
        }

        static string GetNameOfVenue(string line)
        {
            int startIndex = line.IndexOf('@') + 1;
            int endIndex = line.LastIndexOf(' ');
            endIndex = line.LastIndexOf(' ', endIndex - 1);
            return line.Substring(startIndex, endIndex - startIndex);
        }

        static long GetCountOfTickets(string line)
        {
            string[] infoAboutTheConcert = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return long.Parse(infoAboutTheConcert[infoAboutTheConcert.Length - 1]);
        }

        static long GetPriceOfTheTicket(string line)
        {
            string[] infoAboutTheConcert = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return long.Parse(infoAboutTheConcert[infoAboutTheConcert.Length - 2]);
        }

        static string GetNameOfSinger(string line)
        {
            return line.Split(new[] {'@'}, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
        }

        static bool IsLineValid(string line)
        {
            if (!line.Contains('@') || !line.Contains(' '))
            {
                return false;
            }
            int index = line.IndexOf('@');
            if (line[index - 1] != ' ')
            {
                return false;
            }
            index = line.LastIndexOf(' ');
            index = line.LastIndexOf(' ', index - 1);
            if (Char.IsDigit(line[index + 1]))
            {
                return true;
            }
            return false;
        } 
    }
}