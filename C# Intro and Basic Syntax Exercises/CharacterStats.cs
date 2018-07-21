using System;
using System.Text;

namespace CSharpIntroduction
{
    class Program
    {
   
        static void Main(string[] args)
        {
            string nameOfCharacter = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: " + nameOfCharacter);
            Console.WriteLine("Health: " + getAttribute(currentHealth, maxHealth));
            Console.WriteLine("Energy: " + getAttribute(currentEnergy, maxEnergy));

        }

        public static string getAttribute(int current, int max)
        {
            StringBuilder text = new StringBuilder();
            text.Append('|');
            for (int i = 0; i < current; ++i)
            {
                text.Append('|');
            }
            for (int i = current; i < max; ++i)
            {
                text.Append('.');
            }
            text.Append('|');
            return text.ToString();
        }
    }
}
