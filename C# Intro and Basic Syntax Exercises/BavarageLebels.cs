using System; 

namespace CSharpIntroduction
{
    class Program
    {
   
        static void Main(string[] args)
        {
            string nameOfProduct = Console.ReadLine();
            int mililitres = int.Parse(Console.ReadLine());
            int caloriesIn100Mililitres = int.Parse(Console.ReadLine());
            int sugarIn100Mililitres = int.Parse(Console.ReadLine());
            double inOneMililitre = mililitres / 100.0;
            Console.WriteLine(mililitres + "ml " + nameOfProduct + ":");
            Console.WriteLine($"{(caloriesIn100Mililitres * inOneMililitre)}kcal, " +
                $"{(sugarIn100Mililitres * inOneMililitre)}g sugars");
        }
    }
}
