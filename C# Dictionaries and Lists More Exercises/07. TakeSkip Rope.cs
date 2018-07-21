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
            string message = Console.ReadLine();
            List<int> numbersList = new List<int>();
            List<char> nonNumbersList = new List<char>();
            GetDigitsAndLetters(numbersList, nonNumbersList, message);
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            GetTakeAndSkipList(takeList, skipList, numbersList);
            int take = 0;
            int skip = 0;            
            StringBuilder decryptedCommand = new StringBuilder();
            for (int i = 0; i < takeList.Count; i++)
            {
                take = takeList[i];
                decryptedCommand.Append(string.Join("", nonNumbersList.Skip(skip).Take(take)));
                skip += skipList[i] + takeList[i];
            }
            Console.WriteLine(decryptedCommand);
        }

        static void GetTakeAndSkipList(List<int> takeList, List<int> skipList, List<int> numbersList)
        {
            int counter = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(int.Parse(numbersList[counter++] + ""));
                }
                else
                {
                    skipList.Add(int.Parse(numbersList[counter++] + ""));
                }
            }
        }

        static string Take(string message, int length)
        {
            if (length > message.Length)
            {
                length = message.Length;
            }
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                text.Append(message[i]);
            }
            return text.ToString();
        }

        static void GetDigitsAndLetters(List<int> numbersList, List<char> nonNumbersList, string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    numbersList.Add(int.Parse(message[i] + ""));
                }
                else
                {
                    nonNumbersList.Add(message[i]);
                }
            }
        }
    }
}