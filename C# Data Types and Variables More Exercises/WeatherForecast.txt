using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            sbyte n1;
            int n2;
            long n3;
            double n4;
            if (sbyte.TryParse(number, out n1))
            {
                Console.WriteLine("Sunny");
            }
            else if (int.TryParse(number, out n2))
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.TryParse(number, out n3))
            {
                Console.WriteLine("Windy");
            }
            else if (double.TryParse(number, out n4))
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
