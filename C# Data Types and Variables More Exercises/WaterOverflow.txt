using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentCapacity = 0;
            for (int i = 0; i < n; ++i)
            {
                int litres = int.Parse(Console.ReadLine());
                if ((currentCapacity + litres) <= 255)
                {
                    currentCapacity += litres;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currentCapacity);
        }
    }
}
