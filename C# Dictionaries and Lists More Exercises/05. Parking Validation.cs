using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> reservedVenues = new Dictionary<string, string>();
            int countOfPlates = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfPlates; i++)
            {
                string[] infoAboutUser = GetInfoAboutUser(Console.ReadLine());
                string command = GetCommand(infoAboutUser);
                string username = GetUsername(infoAboutUser);

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = GetLicensePlateNumber(infoAboutUser);
                        
                        if (!reservedVenues.ContainsKey(username) && !reservedVenues.ContainsValue(licensePlateNumber)
                            && IsLicensePlateValid(licensePlateNumber))
                        {
                            AddNewUser(reservedVenues, username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            if (reservedVenues.ContainsKey(username))
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {reservedVenues[username]}");
                            }
                            else if (!IsLicensePlateValid(licensePlateNumber))
                            {
                                Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                            }
                            else if (reservedVenues.ContainsValue(licensePlateNumber))
                            {
                                Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                            }
                        }
                        break;
                    case "unregister":
                        if (!reservedVenues.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            Console.WriteLine($"user {username} unregistered successfully");
                            reservedVenues.Remove(username);
                        }
                        break;
                }
            }
           PrintResults(reservedVenues);
        }

        static void PrintResults(Dictionary<string, string> reservedVenues)
        {
            foreach (string username in reservedVenues.Keys)
            {
                Console.WriteLine($"{username} => {reservedVenues[username]}");
            }
        }
        
        static void AddNewUser(Dictionary<string, string> reservedVenues, string username, string licensePlateNumber)
        {
            reservedVenues.Add(username, licensePlateNumber);
        }

        static string GetLicensePlateNumber(string[] infoAboutUser)
        {
            return infoAboutUser[2];
        }

        static string GetCommand(string[] infoAboutUser)
        {
            return infoAboutUser[0];
        }

        static string GetUsername(string[] infoAboutUser)
        {
            return infoAboutUser[1];
        }

        static string[] GetInfoAboutUser(string input)
        {
            return input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        }

        static bool IsLicensePlateValid(string licensePlateNumber)
        {
            if (licensePlateNumber.Length != 8)
            {
                return false;
            }
            string partThatContainsOnlyLetters = licensePlateNumber.Substring(0, 2) + licensePlateNumber.Substring(6, 2);
            string partThetContainsOnlyDigits = licensePlateNumber.Substring(2, 4);

            if (partThatContainsOnlyLetters.Any(letter => !char.IsLetter(letter) || !char.IsUpper(letter)))
            {
                return false;
            }
            if (partThetContainsOnlyDigits.Any(letter => !char.IsDigit(letter)))
            {
                return false;
            }
            return true;
        }
    }
}