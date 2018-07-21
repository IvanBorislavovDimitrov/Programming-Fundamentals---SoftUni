using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            double number;
            if (double.TryParse(line, out number))
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
