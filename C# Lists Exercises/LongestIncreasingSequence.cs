using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {    
        public static void Main()
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
         
            List<int> longestSubsequence = FindLongestIncreasingSubsequence(listOfIntegers);
         
            Console.WriteLine(string.Join(" ", longestSubsequence));
        }
         
        public static List<int> FindLongestIncreasingSubsequence(List<int> givenSequence)
        {
            int[] length = new int[givenSequence.Count];
            int[] prev = new int[givenSequence.Count];
         
            int maxLength = 0;
            int lastIndex = -1;
         
            for (int i = 0; i < givenSequence.Count; i++)
            {
                length[i] = 1;
                prev[i] = -1;
         
                for (int j = 0; j < i; j++)
                {
                    if (givenSequence[j] < givenSequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }
         
                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
         
            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(givenSequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }
         
            longestSeq.Reverse();
            return longestSeq.ToList();
        }
    }
}
