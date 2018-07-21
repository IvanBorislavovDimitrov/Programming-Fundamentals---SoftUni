using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
            {
                for (int m = 1; m <= 4; m++)
                {
                    for (int n = 1; n <= 4; n++)
                    {
                        if (i + m + n >= sum)
                        {
                            Console.Write("O");
                            if (i == 1) { Console.Write("A"); }
                            if (i == 2) { Console.Write("C"); }
                            if (i == 3) { Console.Write("G"); }
                            if (i == 4) { Console.Write("T"); }

                            var secondLetter = m;
                            if (m == 1) { Console.Write("A"); }
                            if (m == 2) { Console.Write("C"); }
                            if (m == 3) { Console.Write("G"); }
                            if (m == 4) { Console.Write("T"); }

                            var thirdLetter = n;
                            if (n == 1) { Console.Write("A"); }
                            if (n == 2) { Console.Write("C"); }
                            if (n == 3) { Console.Write("G"); }
                            if (n == 4) { Console.Write("T"); }
                            Console.Write("O");
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("X");
                            if (i == 1) { Console.Write("A"); }
                            if (i == 2) { Console.Write("C"); }
                            if (i == 3) { Console.Write("G"); }
                            if (i == 4) { Console.Write("T"); }

                            var secondLetter = m;
                            if (m == 1) { Console.Write("A"); }
                            if (m == 2) { Console.Write("C"); }
                            if (m == 3) { Console.Write("G"); }
                            if (m == 4) { Console.Write("T"); }

                            var thirdLetter = n;
                            if (n == 1) { Console.Write("A"); }
                            if (n == 2) { Console.Write("C"); }
                            if (n == 3) { Console.Write("G"); }
                            if (n == 4) { Console.Write("T"); }
                            Console.Write("X");
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}