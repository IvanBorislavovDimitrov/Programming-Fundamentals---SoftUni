using System;
using System.Linq;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] numbersToJump = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            long sum = 0;
            int startIndex = 0;
            while (true)
            {
                sum += numbersToJump[startIndex];
                if ((numbersToJump[startIndex] + startIndex) < numbersToJump.Length)
                {
                    startIndex += numbersToJump[startIndex]; 
                }
                else if ((startIndex - numbersToJump[startIndex]) >= 0)
                {
                    startIndex -= numbersToJump[startIndex];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
