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
            double[] pricesOfProducts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            quantitesOfProducts = RecalculateQuantites(quantitesOfProducts, products.Length);


            string line;
            while ((line = Console.ReadLine()) != "done")
            {
                string product = line.Split(' ')[0];
                long neededQuantity = long.Parse(line.Split(' ')[1]);
                int searchedIndex = GetIndexOfSearchedProduct(product, products);
                
                if (quantitesOfProducts[searchedIndex] >= neededQuantity)
                {
                    Console.WriteLine($"{products[searchedIndex]} x " +
                        $"{neededQuantity} costs " +
                        $"{(pricesOfProducts[searchedIndex] * neededQuantity):F2}");
                    quantitesOfProducts[searchedIndex] -= neededQuantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[searchedIndex]}");
                }

            }
        }

        static long[] RecalculateQuantites(long[] quantities, int lengthOfNeededArr)
        {
            long[] arr = new long[lengthOfNeededArr];
            if (lengthOfNeededArr > quantities.Length)
            {
                Array.Copy(quantities, arr, quantities.Length);
            }
            else
            {
                Array.Copy(quantities, arr, lengthOfNeededArr);
            }
            return arr;
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
