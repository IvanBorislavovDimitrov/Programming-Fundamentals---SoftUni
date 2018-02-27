using System;
using System.Linq;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int lengthOfAppropriateIngrediants = int.Parse(Console.ReadLine());
            string[] addedIngredients = new string[ingredients.Length];
            int coutner = 0;

            for (int i = 0; i < ingredients.Length; ++i)
            {
                if (IsIngreadiantAppropriate(ingredients[i].Length, lengthOfAppropriateIngrediants))
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    addedIngredients[coutner++] = ingredients[i];
                    if (coutner == 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Made pizza with total of {coutner} ingredients.");
            string addedIngredientsToString = string.Join(", ", addedIngredients, 0, coutner);
            Console.WriteLine($"The ingredients are: {addedIngredientsToString}.");
        }

        static bool IsIngreadiantAppropriate(int currnetLength, int length)
        {
            if (currnetLength == length)
            {
                return true;
            }
            return false;
        }
    }
}
