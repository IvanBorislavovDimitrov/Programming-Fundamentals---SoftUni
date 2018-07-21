using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfCalories = 0;
            for (int i = 0; i < n; ++i)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        sumOfCalories += 500;
                        break;
                    case "tomato sauce":
                        sumOfCalories += 150;
                        break;
                    case "salami":
                        sumOfCalories += 600;
                        break;
                    case "pepper":
                        sumOfCalories += 50;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {sumOfCalories}");  
        }
    }
}
