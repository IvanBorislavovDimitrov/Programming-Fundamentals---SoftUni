using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class StatsOfTheDragon
    {
        private double damageOfTheDragon;
        private double healthOfTheDragon;
        private double armorOfTheDragon;

        public StatsOfTheDragon()
        {
            this.DamageOfTheDragon = 0;
            this.HealthOfTheDragon = 0;
            this.ArmorOfTheDragon = 0;
        }
        

        public double DamageOfTheDragon
        {
            get => damageOfTheDragon;
            set => damageOfTheDragon = value;
        }

        public double HealthOfTheDragon
        {
            get => healthOfTheDragon;
            set => healthOfTheDragon = value;
        }

        public double ArmorOfTheDragon
        {
            get => armorOfTheDragon;
            set => armorOfTheDragon = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, StatsOfTheDragon>> dragons =
                new Dictionary<string, SortedDictionary<string, StatsOfTheDragon>>();
            
            int countOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfInputs; i++)
            {
                string line = Console.ReadLine();
                string[] infoAboutTheDragon = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                
                string nameOfTheDragon = GetNameOfTheDragon(infoAboutTheDragon);
                string typeOfTheDragon = GetTypeOfTheDragon(infoAboutTheDragon);
                double damageOfTheDragon = GetDamageOfTheDragon(infoAboutTheDragon);
                double healthOfTheDragon = GetHealthOfTheDragon(infoAboutTheDragon);
                double armorOfTheDragon = GetArmorOfTheDragon(infoAboutTheDragon);
                
                if (!dragons.ContainsKey(typeOfTheDragon))
                {
                    dragons.Add(typeOfTheDragon, new SortedDictionary<string, StatsOfTheDragon>());
                    dragons[typeOfTheDragon].Add(nameOfTheDragon, new StatsOfTheDragon());
                    dragons[typeOfTheDragon][nameOfTheDragon].DamageOfTheDragon = damageOfTheDragon;
                    dragons[typeOfTheDragon][nameOfTheDragon].HealthOfTheDragon = healthOfTheDragon;
                    dragons[typeOfTheDragon][nameOfTheDragon].ArmorOfTheDragon = armorOfTheDragon;
                }
                else
                {
                    if (!dragons[typeOfTheDragon].ContainsKey(nameOfTheDragon))
                    {
                        dragons[typeOfTheDragon].Add(nameOfTheDragon, new StatsOfTheDragon());
                        dragons[typeOfTheDragon][nameOfTheDragon].DamageOfTheDragon = damageOfTheDragon;
                        dragons[typeOfTheDragon][nameOfTheDragon].HealthOfTheDragon = healthOfTheDragon;
                        dragons[typeOfTheDragon][nameOfTheDragon].ArmorOfTheDragon = armorOfTheDragon;
                    }
                    else
                    {
                        dragons[typeOfTheDragon][nameOfTheDragon].DamageOfTheDragon = damageOfTheDragon;
                        dragons[typeOfTheDragon][nameOfTheDragon].HealthOfTheDragon = healthOfTheDragon;
                        dragons[typeOfTheDragon][nameOfTheDragon].ArmorOfTheDragon = armorOfTheDragon;
                    }
                }
            }
            foreach (string typeOfDragon in dragons.Keys)
            {
                double averageDamageOfTheDragon = CalculateAverageDamageOfTheDragons(dragons[typeOfDragon]);
                double averageHealthOfTheDragon = CalculateAverageHealthOfTheDragons(dragons[typeOfDragon]);
                double averageArmorOfTheDragon = CalculateAverageArmorOfTheDragons(dragons[typeOfDragon]);
                Console.WriteLine($"{typeOfDragon}::({averageDamageOfTheDragon:F2}/{averageHealthOfTheDragon:F2}" +
                                  $"/{averageArmorOfTheDragon:F2})");
                foreach (string nameOfDragon in dragons[typeOfDragon].Keys)
                {
                    Console.WriteLine($"-{nameOfDragon} -> " +
                                      $"damage: {dragons[typeOfDragon][nameOfDragon].DamageOfTheDragon}, " +
                                      $"health: {dragons[typeOfDragon][nameOfDragon].HealthOfTheDragon}, " +
                                      $"armor: {dragons[typeOfDragon][nameOfDragon].ArmorOfTheDragon}");
                }
            }
        }

        static double CalculateAverageArmorOfTheDragons(
            SortedDictionary<string, StatsOfTheDragon> typeOfDragon)
        {
            double sumOfAllArmor = 0;
            int counter = 0;
            foreach (string nameOfDragon in typeOfDragon.Keys)
            {
                sumOfAllArmor += typeOfDragon[nameOfDragon].ArmorOfTheDragon;
                counter++;
            }
            return sumOfAllArmor / counter;
        }

        static double CalculateAverageHealthOfTheDragons(
            SortedDictionary<string, StatsOfTheDragon> typeOfDragon)
        {
            double sumOfAllHealth = 0;
            int counter = 0;
            foreach (string nameOfDragon in typeOfDragon.Keys)
            {
                sumOfAllHealth += typeOfDragon[nameOfDragon].HealthOfTheDragon;
                counter++;
            }
            return sumOfAllHealth / counter;
        }

        static double CalculateAverageDamageOfTheDragons(
            SortedDictionary<string, StatsOfTheDragon> typeOfDragon)
        {
            double sumOfAllDamages = 0;
            int counter = 0;
            foreach (string nameOfDragon in typeOfDragon.Keys)
            {
                sumOfAllDamages += typeOfDragon[nameOfDragon].DamageOfTheDragon;
                counter++;
            }
            return sumOfAllDamages / counter;
        }

        static string GetNameOfTheDragon(string[] infoAboutTheDragon)
        {
            return infoAboutTheDragon[1];
        }

        static string GetTypeOfTheDragon(string[] infoAboutTheDragon)
        {
            return infoAboutTheDragon[0];
        }

        static double GetDamageOfTheDragon(string[] infoAboutTheDragon)
        {
            string damage = infoAboutTheDragon[2].ToLower();
            if (damage == "null")
            {
                return 45d;
            }
            return double.Parse(damage);
        }

        static double GetHealthOfTheDragon(string[] infoAboutTheDragon)
        {
            string health = infoAboutTheDragon[3];
            if (health == "null")
            {
                return 250d;
            }
            return double.Parse(health);
        }

        static double GetArmorOfTheDragon(string[] infoAboutTheDragon)
        {
            string armor = infoAboutTheDragon[4];
            if (armor == "null")
            {
                return 10d;
            }
            return double.Parse(armor);
        }
    }
}