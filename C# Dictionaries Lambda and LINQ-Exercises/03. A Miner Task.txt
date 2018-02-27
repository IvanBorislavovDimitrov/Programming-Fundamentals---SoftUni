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
            Dictionary<string, long> bookOfMiner = new Dictionary<string, long>();
            string material;
            while ((material = Console.ReadLine()) != "stop")
            {
                long resourceToAdd = long.Parse(Console.ReadLine());
                if (!bookOfMiner.ContainsKey(material))
                {
                    bookOfMiner.Add(material, resourceToAdd);
                }
                else
                {
                    bookOfMiner[material] += resourceToAdd;
                }
            }
            foreach (var item in bookOfMiner.Keys)
            {
                Console.WriteLine(item + " -> " + bookOfMiner[item]);
            }
        }
    }
}