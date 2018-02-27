using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main()
        {
            char[] firstCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            Console.WriteLine(GetSmallerCharArray(firstCharArray, secondCharArray));
            Console.WriteLine(GetBiggerCharArray(firstCharArray, secondCharArray));
        }

        public static char[] GetSmallerCharArray(char[] firstArr, char[] secondArr)
        {
            for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); ++i)
            {
                if (firstArr[i] > secondArr[i])
                {
                    return secondArr;
                }
            }
            if (firstArr.Length > secondArr.Length)
            {
                return secondArr;
            }

            return firstArr;
        }

        public static char[] GetBiggerCharArray(char[] firstArr, char[] secondArr)
        {
            for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); ++i)
            {
                if (firstArr[i] > secondArr[i])
                {
                    return firstArr;
                }
            }
            if (firstArr.Length > secondArr.Length)
            {
                return firstArr;
            }

             return secondArr;
        }
    }
}
