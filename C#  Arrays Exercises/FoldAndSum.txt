using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main()
        {
            long[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int startPositionOfLeftPart = numbers.Length / 4 - 1;
            int endPositionOfLeftPart = 0;
            int startPostitionOfRightPart = numbers.Length - 1;
            int endPositionOfRightPart = startPostitionOfRightPart - numbers.Length / 4 + 1;

            int lengthOfSummedArray = numbers.Length / 2;
            long[] summedArray = new long[lengthOfSummedArray];

            int index = 0;    
            for (int i = startPositionOfLeftPart; i >= endPositionOfLeftPart; --i, ++index)
            {
                summedArray[index] = numbers[i];
            }

            
            for (int i = startPostitionOfRightPart; i >= endPositionOfRightPart; --i)
            {
                summedArray[index++] = numbers[i];
            }
            index = 0;
            for (int i = startPositionOfLeftPart + 1; i < endPositionOfRightPart; ++i, index++)
            {
                summedArray[index] += numbers[i];
            }
            Console.WriteLine(string.Join(" ", summedArray));
        }
    }
}
