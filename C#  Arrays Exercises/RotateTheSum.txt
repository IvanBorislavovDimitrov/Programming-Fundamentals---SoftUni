using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main()
        {
            long[] longArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int timesToRotate = int.Parse(Console.ReadLine());

            if (timesToRotate == 1)
            {
                RotateArray(longArray);
                Console.WriteLine(string.Join(" ", longArray));
            }
            else
            {
                long[] sumArray = new long[longArray.Length];
                for (int i = 0; i < timesToRotate; ++i)
                {
                    RotateArray(longArray);
                    SumArray(sumArray, longArray);
                }
                Console.WriteLine(string.Join(" ", sumArray));
            }

        }

        public static void SumArray(long[] arr, long[] arrayToAdd)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] += arrayToAdd[i];
            }
        }

        public static void RotateArray(long[] arr)
        {
            for (int i = arr.Length - 1; i > 0; --i)
            {
                long swap = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = swap;
            }
        }
    }
}
