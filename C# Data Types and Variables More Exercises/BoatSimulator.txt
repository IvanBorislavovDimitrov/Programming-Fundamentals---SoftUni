using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int boat1 = char.Parse(Console.ReadLine());
            int boat2 = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sumOfBoat1 = 0;
            int sumOfBoat2 = 0;
            for (int i = 1; i <= n; ++i)
            {
                string input = Console.ReadLine();
                if (input == "UPGRADE")
                {
                    boat1 += 3;
                    boat2 += 3;
                    continue;
                }
                if (i % 2 != 0)
                {
                    sumOfBoat1 += input.Length;
                }
                else
                {
                    sumOfBoat2 += input.Length;
                }
                if (sumOfBoat1 >= 50)
                {
                    Console.WriteLine((char)boat1);
                    return;
                }
                if (sumOfBoat2 >= 50)
                {
                    Console.WriteLine((char)boat2);
                    return;
                }
            }
            if (sumOfBoat1 > sumOfBoat2)
            {
                Console.WriteLine((char)boat1);
            }
            else
            {
                Console.WriteLine((char)boat2);
            }
        }
    }
}
