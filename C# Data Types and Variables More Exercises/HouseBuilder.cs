using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int num1;
            sbyte num2;
            if (sbyte.TryParse(first, out num2))
            {
                num1 = int.Parse(second);
                long num = 4L * num2 + 10L * num1;
                Console.WriteLine(num);
            }
            else
            {
                num1 = int.Parse(first);
                num2 = sbyte.Parse(second);
                long num = 10L * num1 + 4L * num2;
                Console.WriteLine(num);
            }
        }
    }
}
