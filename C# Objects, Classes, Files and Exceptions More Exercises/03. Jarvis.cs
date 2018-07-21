using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Program
{
    
    class Program
    {
        class Arm
        {
            public long EnergyConsumption { get; set; }
            
            public long ArmReachDistance { get; set; }
            
            public long CountOfFingers { get; set; }
        }

        class Leg
        {
            public long EnergyConsumption { get; set; }
            
            public long Strength { get; set; }
            
            public long Speed { get; set; } 
        }

        class Torso
        {
            public long EnergyConsumption { get; set; }
            
            public double ProcessorSizeInCantimtres { get; set; }
            
            public string HousingMaterial { get; set; }
        }

        class Head
        {
            public long EnergyConsumption { get; set; }
            
            public long Iq { get; set; }
            
            public string SkinMaterial { get; set; }
        }
        
        static void Main()
        {
            Arm leftArm = new Arm();
            Arm rightArm = new Arm();
            Leg leftLeg = new Leg();
            Leg rightLeg = new Leg();
            Torso torso = new Torso();
            Head head = new Head();
            
            bool isThereLeftArm = false;
            bool isThereRightArm = false;
            bool isThereLeftLeg = false;
            bool isThereRightLeg = false;
            bool isThereTorso = false;
            bool isThereHead = false;
            
            long maximumEnergyCapacity = long.Parse(Console.ReadLine());
            long sumOfEnergy = 0;
            string line;
            while ((line = Console.ReadLine()) != "Assemble!")
            {
                string[] infoAboutPart = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string part = infoAboutPart[0];
                switch (part)
                {
                    case "Torso":
                        long energyConsumption = long.Parse(infoAboutPart[1]);
                        double processorSizeInCantimtres = double.Parse(infoAboutPart[2]);
                        string housingMaterial = infoAboutPart[3];
                        if (!isThereTorso)
                        {
                            torso.EnergyConsumption = energyConsumption;
                            torso.ProcessorSizeInCantimtres = processorSizeInCantimtres;
                            torso.HousingMaterial = housingMaterial;
                            isThereTorso = true;
                        }
                        else
                        {
                            if (torso.EnergyConsumption > energyConsumption)
                            {
                                torso.EnergyConsumption = energyConsumption;
                                torso.ProcessorSizeInCantimtres = processorSizeInCantimtres;
                                torso.HousingMaterial = housingMaterial;
                            }
                        }
                        break;
                    case "Head":
                        infoAboutPart = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                        energyConsumption = long.Parse(infoAboutPart[1]);
                        long iq = long.Parse(infoAboutPart[2]);
                        string skinMaterial = infoAboutPart[3];
                        if (!isThereHead)
                        {
                            head.EnergyConsumption = energyConsumption;
                            head.Iq = iq;
                            head.SkinMaterial = skinMaterial;
                            isThereHead = true;
                        }
                        else
                        {
                            if (head.EnergyConsumption > energyConsumption)
                            {
                                head.EnergyConsumption = energyConsumption;
                                head.Iq = iq;
                                head.SkinMaterial = skinMaterial;
                            }
                        }
                        break;
                    case "Leg":
                        energyConsumption = long.Parse(infoAboutPart[1]);
                        long strength = long.Parse(infoAboutPart[2]);
                        long speed = long.Parse(infoAboutPart[3]);
                        if (!isThereLeftLeg)
                        {
                            leftLeg.EnergyConsumption = energyConsumption;
                            leftLeg.Speed = speed;
                            leftLeg.Strength = strength;
                            isThereLeftLeg = true;
                        }
                        else if (!isThereRightLeg)
                        {
                            rightLeg.EnergyConsumption = energyConsumption;
                            rightLeg.Speed = speed;
                            rightLeg.Strength = strength;
                            isThereRightLeg = true;
                        }
                        else if (leftLeg.EnergyConsumption > energyConsumption)
                        {
                            leftLeg.EnergyConsumption = energyConsumption;
                            leftLeg.Speed = speed;
                            leftLeg.Strength = strength;
                        }
                        else if (rightLeg.EnergyConsumption > energyConsumption)
                        {
                            rightLeg.EnergyConsumption = energyConsumption;
                            rightLeg.Speed = speed;
                            rightLeg.Strength = strength;
                        }
                        break;
                    case "Arm":
                        energyConsumption = long.Parse(infoAboutPart[1]);
                        long armRechDistance = long.Parse(infoAboutPart[2]);
                        long countOfFingers = long.Parse(infoAboutPart[3]);
                        if (!isThereLeftArm)
                        {
                            leftArm.EnergyConsumption = energyConsumption;
                            leftArm.ArmReachDistance = armRechDistance;
                            leftArm.CountOfFingers = countOfFingers;
                            isThereLeftArm = true;
                        }
                        else if (!isThereRightArm)
                        {
                            rightArm.EnergyConsumption = energyConsumption;
                            rightArm.ArmReachDistance = armRechDistance;
                            rightArm.CountOfFingers = countOfFingers;
                            isThereRightArm = true;
                        }
                        else if (leftArm.EnergyConsumption > energyConsumption)
                        {
                            leftArm.EnergyConsumption = energyConsumption;
                            leftArm.ArmReachDistance = armRechDistance;
                            leftArm.CountOfFingers = countOfFingers;
                        }
                        else if (rightArm.EnergyConsumption > energyConsumption)
                        {
                            rightArm.EnergyConsumption = energyConsumption;
                            rightArm.ArmReachDistance = armRechDistance;
                            rightArm.CountOfFingers = countOfFingers;
                        }
                        break;
                }
            }
            sumOfEnergy = GetTotalSum(leftArm, rightArm, leftLeg, rightLeg, torso, head);
            if (sumOfEnergy > maximumEnergyCapacity)
            {
                Console.WriteLine("We need more power!");
            }
            else if (!(isThereHead && isThereTorso && isThereLeftArm && isThereRightArm && isThereLeftLeg
                           && isThereRightLeg)) 
            {
               Console.WriteLine("We need more parts!");
            }
            else
            {
                Console.WriteLine("Jarvis:");
                Console.WriteLine("#Head:");
                Console.WriteLine($"###Energy consumption: {head.EnergyConsumption}");
                Console.WriteLine($"###IQ: {head.Iq}");
                Console.WriteLine($"###Skin material: {head.SkinMaterial}");
                Console.WriteLine("#Torso:");
                Console.WriteLine($"###Energy consumption: {torso.EnergyConsumption}");
                Console.WriteLine($"###Processor size: {torso.ProcessorSizeInCantimtres:F1}");
                Console.WriteLine($"###Corpus material: {torso.HousingMaterial}");

                if (leftArm.EnergyConsumption <= rightArm.EnergyConsumption)
                {
                    Console.WriteLine("#Arm:");    
                    Console.WriteLine($"###Energy consumption: {leftArm.EnergyConsumption}");
                    Console.WriteLine($"###Reach: {leftArm.ArmReachDistance}");
                    Console.WriteLine($"###Fingers: {leftArm.CountOfFingers}");
                    Console.WriteLine("#Arm:");
                    Console.WriteLine($"###Energy consumption: {rightArm.EnergyConsumption}");
                    Console.WriteLine($"###Reach: {rightArm.ArmReachDistance}");
                    Console.WriteLine($"###Fingers: {rightArm.CountOfFingers}");
                }
                else
                {
                    Console.WriteLine("#Arm:");
                    Console.WriteLine($"###Energy consumption: {rightArm.EnergyConsumption}");
                    Console.WriteLine($"###Reach: {rightArm.ArmReachDistance}");
                    Console.WriteLine($"###Fingers: {rightArm.CountOfFingers}");
                    Console.WriteLine("#Arm:");
                    Console.WriteLine($"###Energy consumption: {leftArm.EnergyConsumption}");
                    Console.WriteLine($"###Reach: {leftArm.ArmReachDistance}");
                    Console.WriteLine($"###Fingers: {leftArm.CountOfFingers}");
                }
                if (leftLeg.EnergyConsumption <= rightLeg.EnergyConsumption)
                {
                    Console.WriteLine("#Leg:");
                    Console.WriteLine($"###Energy consumption: {leftLeg.EnergyConsumption}");
                    Console.WriteLine($"###Strength: {leftLeg.Strength}");
                    Console.WriteLine($"###Speed: {leftLeg.Speed}");
                    Console.WriteLine("#Leg:");
                    Console.WriteLine($"###Energy consumption: {rightLeg.EnergyConsumption}");
                    Console.WriteLine($"###Strength: {rightLeg.Strength}");
                    Console.WriteLine($"###Speed: {rightLeg.Speed}");
                }
                else
                {
                    Console.WriteLine("#Leg:");
                    Console.WriteLine($"###Energy consumption: {rightLeg.EnergyConsumption}");
                    Console.WriteLine($"###Strength: {rightLeg.Strength}");
                    Console.WriteLine($"###Speed: {rightLeg.Speed}");
                    Console.WriteLine("#Leg:");
                    Console.WriteLine($"###Energy consumption: {leftLeg.EnergyConsumption}");
                    Console.WriteLine($"###Strength: {leftLeg.Strength}");
                    Console.WriteLine($"###Speed: {leftLeg.Speed}");
                }
            }      
        }

        static long GetTotalSum(Arm leftArm, Arm rightArm, Leg leftLeg, Leg rightLeg, Torso torso, Head head)
        {
            long sum;
            sum = leftArm.EnergyConsumption + rightArm.EnergyConsumption + leftLeg.EnergyConsumption +
                  rightLeg.EnergyConsumption + torso.EnergyConsumption + head.EnergyConsumption;
            return sum;
        }
    }
}