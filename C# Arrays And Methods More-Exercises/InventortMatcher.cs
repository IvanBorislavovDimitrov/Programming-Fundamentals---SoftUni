using System;
using System.Linq;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantitesOfProducts = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] pricesOfProducts = Console.ReadLine().Split(' ');

            string product;
            while ((product = Console.ReadLine()) != "done")
            {
                int searchedIndex = GetIndexOfSearchedProduct(product, products);
                Console.WriteLine($"{products[searchedIndex]} costs:" +
                    $" {pricesOfProducts[searchedIndex]}; Available quantity: {quantitesOfProducts[searchedIndex]}");
            }
        }

        static int GetIndexOfSearchedProduct(string product, string[] products)
        {
            for (int i = 0; i < products.Length; ++i)
            {
                if (product == products[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
