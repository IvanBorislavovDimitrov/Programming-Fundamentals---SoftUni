using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintingFilledRectangle(int.Parse(Console.ReadLine()));
        }
        public static void PrintingFilledRectangle(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
            for (int j = 1; j < number - 1; ++j)
            {
                Console.Write("-");
                for (int i = 1; i < number; ++i)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
            Console.WriteLine(new string('-', 2 * number));
        }
    }
}
