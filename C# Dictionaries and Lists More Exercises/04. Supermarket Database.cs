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
            Dictionary<string, double> productAndPrice = new Dictionary<string, double>();
            Dictionary<string, int> productAndQuantity = new Dictionary<string, int>();
            string line;
            while ((line = Console.ReadLine()) != "stocked")
            {
                string[] infoAboutProduct = line.Split(' ');
                string nameOfProduct = infoAboutProduct[0];
                double priceOfProduct = double.Parse(infoAboutProduct[1]);
                int quantityOfProduct = int.Parse(infoAboutProduct[2]);

                if (!productAndPrice.ContainsKey(nameOfProduct))
                {
                    productAndPrice.Add(nameOfProduct, priceOfProduct);
                    productAndQuantity.Add(nameOfProduct, quantityOfProduct);
                }
                else
                {
                    productAndPrice[nameOfProduct] = priceOfProduct;
                    productAndQuantity[nameOfProduct] += quantityOfProduct;
                }
            }
            double sum = 0;
            foreach (string product in productAndPrice.Keys)
            {
                Console.WriteLine($"{product}: ${productAndPrice[product]:F2} * {productAndQuantity[product]} " +
                                  $"= ${productAndPrice[product] * productAndQuantity[product]:F2}");
                sum += productAndPrice[product] * productAndQuantity[product];
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${sum:F2}");
        }
    }
}