using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string isItTrue = Console.ReadLine();
            bool isIt = Convert.ToBoolean(isItTrue);
            Console.WriteLine(isIt ? "Yes" : "No");
        }
    }
}