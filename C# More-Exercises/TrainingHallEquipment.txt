using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 0; i < n; ++i)
            {
                string nameOfProduct = Console.ReadLine();
                double priceOfProduct = double.Parse(Console.ReadLine());
                int quantityOfProduct = int.Parse(Console.ReadLine());
                if (quantityOfProduct > 1)
                {
                    nameOfProduct += "s";
                }
                totalSum += priceOfProduct * quantityOfProduct;
                Console.WriteLine($"Adding {quantityOfProduct} {nameOfProduct} to card.");
                budget -= (priceOfProduct * quantityOfProduct);
            }
            Console.WriteLine($"Subtotal: ${totalSum:F2}");
            if (budget >= 0)
            {
                Console.WriteLine($"Money left: {budget:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget):F2} more.");
            }
        }
    }
}