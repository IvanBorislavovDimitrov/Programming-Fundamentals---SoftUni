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
            Dictionary<string, int> resultOfEachPlayer = new Dictionary<string, int>();
            resultOfEachPlayer.Add("Shadowmourne", 0);
            resultOfEachPlayer.Add("Valanyr", 0);
            resultOfEachPlayer.Add("Dragonwrath", 0);
            SortedDictionary<string, int> keyMaterials = new SortedDictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();
            string winner = string.Empty;
            while (true)
            {
                string line = Console.ReadLine();
                string[] infoAboutItems = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToLower()).ToArray();
                
                ComputeValuesOfItems(infoAboutItems, resultOfEachPlayer, keyMaterials, junkItems);
                
                if (resultOfEachPlayer["Shadowmourne"] >= 250)
                {
                    winner = "Shadowmourne";
                    keyMaterials["shards"] -= 250;
                    break;
                }
                if (resultOfEachPlayer["Valanyr"] >= 250)
                {
                    winner = "Valanyr";
                    keyMaterials["fragments"] -= 250;
                    break;
                }
                if (resultOfEachPlayer["Dragonwrath"] >= 250)
                {
                    winner = "Dragonwrath";
                    keyMaterials["motes"] -= 250;
                    break;
                }
            }
            Console.WriteLine($"{winner} obtained!");
            var sortedKeyMaterials = keyMaterials.ToList();
            sortedKeyMaterials.Sort((x1, x2) =>
            {
                if (x2.Value.CompareTo(x1.Value) == 0)
                {
                    return String.Compare(x1.Key, x2.Key, StringComparison.Ordinal);
                }
                return x2.Value.CompareTo(x1.Value);
            });
            foreach (var material in sortedKeyMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var item in junkItems.Keys)
            {
                Console.WriteLine($"{item}: {junkItems[item]}");
            }
        }

        static void ComputeValuesOfItems(string[] infoAboutItems, Dictionary<string, int> resultOfEachPlayer,
            SortedDictionary<string, int> keyMaterials, SortedDictionary<string, int> junkItems)
        {
            for (int i = 0; i < infoAboutItems.Length; i += 2)
            {
                int powerOfMaterial = int.Parse(infoAboutItems[i]);
                string nameOfMaterial = infoAboutItems[i + 1];
                switch (nameOfMaterial)
                {
                     case "motes":
                         keyMaterials["motes"] += powerOfMaterial;
                         resultOfEachPlayer["Dragonwrath"] += powerOfMaterial;
                         if (resultOfEachPlayer["Dragonwrath"] >= 250)
                         {
                             return;
                         }
                         break;
                     case "fragments":
                         keyMaterials["fragments"] += powerOfMaterial;
                         resultOfEachPlayer["Valanyr"] += powerOfMaterial;
                         if (resultOfEachPlayer["Valanyr"] >= 250)
                         {
                             return;
                         }
                         break;
                     case "shards":
                         keyMaterials["shards"] += powerOfMaterial;
                         resultOfEachPlayer["Shadowmourne"] += powerOfMaterial;
                         if (resultOfEachPlayer["Shadowmourne"] >= 250)
                         {
                             return;
                         }
                         break;
                     default:
                         if (!junkItems.ContainsKey(nameOfMaterial))
                         {
                             junkItems.Add(nameOfMaterial, powerOfMaterial);
                         }
                         else
                         {
                             junkItems[nameOfMaterial] += powerOfMaterial;
                         }
                         break;
                }
            }
        }
    }
}