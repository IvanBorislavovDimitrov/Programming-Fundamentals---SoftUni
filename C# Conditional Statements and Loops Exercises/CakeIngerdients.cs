using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string ingredient;
            while ((ingredient = Console.ReadLine()) != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
