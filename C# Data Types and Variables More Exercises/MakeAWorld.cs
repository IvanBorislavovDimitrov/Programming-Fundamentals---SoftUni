using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string buffer = "";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                buffer += Console.ReadLine();
            }
            Console.WriteLine("The word is: " + buffer);
        }
    }
}
