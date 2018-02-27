using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Product
    {
        public string Town { get; set; }
        public string NameOfProduct { get; set; }
        public double TotalPrice { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            int countOfProduct = int.Parse(Console.ReadLine());
            var products = new List<Product>();
            for (int i = 0; i < countOfProduct; i++)
            {
                string[] infoAboutProduct = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                
                string town = infoAboutProduct[0];
                string nameOfProdcut = infoAboutProduct[1];
                double priceOfProduct = double.Parse(infoAboutProduct[2]);
                double quantityOfProduct = double.Parse(infoAboutProduct[3]);
                
                Product product = new Product();
                
                product.Town = town;
                product.NameOfProduct = nameOfProdcut;
                product.TotalPrice = priceOfProduct * quantityOfProduct;
                int containsIndex = DoesSetContainsTown(products, town);
                if (containsIndex == -1)
                {
                    products.Add(product);
                }
                else
                {
                    products[containsIndex].TotalPrice += priceOfProduct * quantityOfProduct;
                }
            }
            products.Sort((x1, x2) => String.Compare(x1.Town, x2.Town, StringComparison.Ordinal));
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Town} -> {product.TotalPrice:F2}");
            }
        }

        static int DoesSetContainsTown(List<Product> products, string town)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Town == town)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
