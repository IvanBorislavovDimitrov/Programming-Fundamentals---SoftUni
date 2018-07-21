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
            HashSet<string> viruses = new HashSet<string>();
            double initialHealth = double.Parse(Console.ReadLine());
            double currentHealt = initialHealth;
            string virusName;
            while ((virusName = Console.ReadLine()) != "end")
            {
                int virusPower = CalculatePowerOfTheVirus(virusName);
                int timeToDefeatTheVirus = CalculateTimeToDefeatTheVirus(virusName, virusPower);
                int minutesToDefeatTheVirus = timeToDefeatTheVirus / 60;
                int secondToDefeatTheVirus = timeToDefeatTheVirus % 60;
                if (!viruses.Contains(virusName))
                {
                    viruses.Add(virusName);
                    currentHealt -= timeToDefeatTheVirus;
                    if (currentHealt > 0)
                    {
                        Console.WriteLine($"Virus {virusName}: {virusPower} => {timeToDefeatTheVirus} seconds");
                        Console.WriteLine($"{virusName} defeated in {minutesToDefeatTheVirus}m " +
                                          $"{secondToDefeatTheVirus}s.");
                        currentHealt = Math.Floor(currentHealt);
                        Console.WriteLine($"Remaining health: {currentHealt}");
                        currentHealt *= 1.2;
                        if (currentHealt > initialHealth)
                        {
                            currentHealt = initialHealth;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Virus {virusName}: {virusPower} => {timeToDefeatTheVirus} seconds");
                        Console.WriteLine("Immune System Defeated.");
                        return;
                    }
                }
                else
                {
                    timeToDefeatTheVirus /= 3;
                    minutesToDefeatTheVirus = timeToDefeatTheVirus / 60;
                    secondToDefeatTheVirus = timeToDefeatTheVirus % 60;
                    currentHealt -= timeToDefeatTheVirus;
                    if (currentHealt > 0)
                    {
                        Console.WriteLine($"Virus {virusName}: {virusPower} => {timeToDefeatTheVirus} seconds");
                        Console.WriteLine($"{virusName} defeated in {minutesToDefeatTheVirus}m " +
                                          $"{secondToDefeatTheVirus}s.");
                        currentHealt = Math.Floor(currentHealt);
                        Console.WriteLine($"Remaining health: {currentHealt}");
                        currentHealt *= 1.2;
                        if (currentHealt > initialHealth)
                        {
                            currentHealt = initialHealth;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Virus {virusName}: {virusPower} => {timeToDefeatTheVirus} seconds");
                        Console.WriteLine("Immune System Defeated.");
                        return;
                    }
                }
            }
            Console.WriteLine($"Final Health: {Math.Floor(currentHealt)}");
        }

        
        static int CalculateTimeToDefeatTheVirus(string virusName, int virusPower)
        {
            return virusPower * virusName.Length;
        }

        static int CalculatePowerOfTheVirus(string virusName)
        {
            int powerOfTheVirus = 0;
            for (int i = 0; i < virusName.Length; i++)
            {
                powerOfTheVirus += virusName[i];
            }
            return powerOfTheVirus / 3;
        }
    }
}