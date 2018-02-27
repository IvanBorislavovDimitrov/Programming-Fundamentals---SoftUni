using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int maxCounterLeft = 0;
            int currentCounterLeft = 0;


            int shorterArrayLength = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < shorterArrayLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    currentCounterLeft++;
                    if (currentCounterLeft > maxCounterLeft)
                    {
                        maxCounterLeft = currentCounterLeft;
                    }
                }
                else
                {
                    currentCounterLeft = 0;
                }
            }
            int currentCounterRight = 0;
            int maxCounterRight = 0;

            for (int i = 0; i < shorterArrayLength; i++)
            {
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    currentCounterRight++;
                    if (currentCounterRight > maxCounterRight)
                    {
                        maxCounterRight = currentCounterRight;
                    }
                }
                else
                {
                    currentCounterRight = 0;
                }
            }
        
            Console.WriteLine(Math.Max(maxCounterLeft, maxCounterRight));
        }
    }
}
