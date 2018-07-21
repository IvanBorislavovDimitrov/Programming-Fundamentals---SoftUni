using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                string[] commands = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "A")
                {
                    if (!phonebook.ContainsKey(commands[1]))
                    {
                        phonebook.Add(commands[1], commands[2]);
                    }
                    else
                    {
                        phonebook[commands[1]] = commands[2];
                    }
                }
                else if (commands[0] == "S")
                {
                    if (phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine(commands[1] + " -> " + phonebook[commands[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commands[1]} does not exist.");
                    }
                }
            }
        }
    }
}