using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int damageOfPesho = int.Parse(Console.ReadLine());
            int damageOfGosho = int.Parse(Console.ReadLine());
            int healthOfPesho = 100;
            int healthOfGosho = 100;
            int count = 1;
            while (true)
            {
                if (count % 2 != 0)
                {
                    if (healthOfGosho - damageOfPesho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {count}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthOfGosho - damageOfPesho} health.");
                    healthOfGosho -= damageOfPesho;
                }
                
                if (count % 2 == 0)
                {
                    if (healthOfPesho - damageOfGosho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {count}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthOfPesho - damageOfGosho} health.");
                    healthOfPesho -= damageOfGosho;
                }
                
                if (count % 3 == 0)
                {
                    healthOfPesho += 10;
                    healthOfGosho += 10;
                }
                count++;
            }
        }
    }
}
