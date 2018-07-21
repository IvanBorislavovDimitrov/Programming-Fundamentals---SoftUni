using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int n = int.Parse(Console.ReadLine());
            switch (type)
            {
                case "sbyte":
                    {
                        sbyte maxValue = sbyte.MinValue;
                        sbyte currentNumber;
                        for (int i = 0; i < n; ++i)
                        {
                            string number = Console.ReadLine();
                            if (sbyte.TryParse(number, out currentNumber))
                            {
                                if (maxValue < currentNumber)
                                {
                                    maxValue = currentNumber;
                                }
                            }
                        }
                        Console.WriteLine(maxValue);
                        break;
                    }
                case "int":
                    {
                        int maxValue = int.MinValue;
                        int currentNumber;
                        for (int i = 0; i < n; ++i)
                        {
                            string number = Console.ReadLine();
                            if (int.TryParse(number, out currentNumber))
                            {
                                if (maxValue < currentNumber)
                                {
                                    maxValue = currentNumber;
                                }
                            }
                        }
                        Console.WriteLine(maxValue);
                        break;
                    }
                case "long":
                    {
                        long maxValue = long.MinValue;
                        long currentNumber;
                        for (int i = 0; i < n; ++i)
                        {
                            string number = Console.ReadLine();
                            if (long.TryParse(number, out currentNumber))
                            {
                                if (maxValue < currentNumber)
                                {
                                    maxValue = currentNumber;
                                }
                            }
                        }
                        Console.WriteLine(maxValue);
                        break;
                    }

            }
        }
    }
}
