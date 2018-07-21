using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Customer
    {
        public string NameOfCustomer { get; set; }

        public Dictionary<string, int> BuyedProducts { get; set; }

        public double FinalBillForTheCustomer { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            int countOfProducts = int.Parse(Console.ReadLine());
            Dictionary<string, double> products = new Dictionary<string, double>();
            
            AddTheProducts(products, countOfProducts);
            
            List<Customer> customers = new List<Customer>();
            
            CalculateOrders(customers, products);
            
            SortCustomers(customers);

            double totalBill = CalculateTotalBill(customers);
            PrintCustomers(customers, totalBill);
        }

        public static double CalculateTotalBill(List<Customer> customers)
        {
            double sum = 0;
            foreach (var customer in customers)
            {
                sum += customer.FinalBillForTheCustomer;
            }
            return sum;
        }

        public static void SortCustomers(List<Customer> customers)
        {
            customers.Sort((x1, x2) => String.Compare(x1.NameOfCustomer, x2.NameOfCustomer, StringComparison.Ordinal));
        }

        public static void PrintCustomers(List<Customer> customers, double totalBill)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.NameOfCustomer}");
                foreach (var product in customer.BuyedProducts)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.FinalBillForTheCustomer:F2}");
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        public static void CalculateOrders(List<Customer> customers, Dictionary<string, double> products)
        {
            string line;
            while ((line = Console.ReadLine()) != "end of clients")
            {
                string[] infoAboutOrder = line.Split(new[] {',', '-'}, StringSplitOptions.RemoveEmptyEntries);
                
                string nameOfClient = infoAboutOrder[0];
                string nameOfProduct = infoAboutOrder[1];
                int quantityOfOrderedProduct = int.Parse(infoAboutOrder[2]);
                
                if (!DoesProductIsInTheMenu(products, nameOfProduct))
                {
                    continue;
                }
                
                int indexOfClient = IndexOfClient(customers, nameOfClient);
                if (indexOfClient == -1)
                {
                    Customer customer = new Customer();
                    customer.NameOfCustomer = nameOfClient;
                    customer.BuyedProducts = new Dictionary<string, int>();
                    customer.BuyedProducts.Add(nameOfProduct, quantityOfOrderedProduct);
                    customer.FinalBillForTheCustomer = products[nameOfProduct] * quantityOfOrderedProduct;
                    customers.Add(customer);
                }
                else
                {
                    if (customers[indexOfClient].BuyedProducts.ContainsKey(nameOfProduct))
                    {
                        customers[indexOfClient].BuyedProducts[nameOfProduct] += quantityOfOrderedProduct;
                        
                        customers[indexOfClient].FinalBillForTheCustomer += 
                            products[nameOfProduct] * quantityOfOrderedProduct;
                    }
                    else
                    {
                        customers[indexOfClient].BuyedProducts.Add(nameOfProduct, quantityOfOrderedProduct);
                        customers[indexOfClient].FinalBillForTheCustomer += 
                            products[nameOfProduct] * quantityOfOrderedProduct;
                    }
                }
            }
        }

        public static bool DoesProductIsInTheMenu(Dictionary<string, double> products, string nameOfProduct)
        {
            if (products.ContainsKey(nameOfProduct))
            {
                return true;
            }
            return false;
        }

        public static int IndexOfClient(List<Customer> customers, string nameOfClient)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].NameOfCustomer == nameOfClient)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void AddTheProducts(Dictionary<string, double> products, int countOfProducts)
        {
            for (int i = 0; i < countOfProducts; i++)
            {
                string[] infoAboutProduct =
                    Console.ReadLine().Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                string nameOfProduct = infoAboutProduct[0];
                double priceOfProduct = double.Parse(infoAboutProduct[1]);

                if (!products.ContainsKey(nameOfProduct))
                {
                    products.Add(nameOfProduct, priceOfProduct);
                }
                else
                {
                    products[nameOfProduct] = priceOfProduct;
                }
            }
        }
    }
}