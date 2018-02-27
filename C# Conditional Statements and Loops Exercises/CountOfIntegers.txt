using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num;
            string line;
            while (int.TryParse(line = Console.ReadLine(), out num))
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
