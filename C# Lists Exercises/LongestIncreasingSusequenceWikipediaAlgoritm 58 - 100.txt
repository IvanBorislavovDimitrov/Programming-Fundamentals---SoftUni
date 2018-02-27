using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int L = 0;
            int n = numbers.Length;
            int[] P = new int[numbers.Length]; 
            int[] M = new int[numbers.Length + 1]; 

            for (int i = 0; i < n; i++)
            {
                int lo = 1;
                int hi = L;
                while (lo <= hi)
                {
                    int mid = (int)Math.Ceiling((lo + hi) / 2.0);
                    if (numbers[M[mid]] < numbers[i])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid - 1;
                    }
                }
                int newL = lo;
                P[i] = M[newL - 1];
                M[newL] = i;

                if (newL > L)
                {
                    L = newL;
                }
            }
            int[] S = new int[L];
            int k = M[L];
            for (int i = L - 1; i >= 0; i--)
            {
                S[i] = numbers[k];
                k = P[k];
            }
            Console.WriteLine(string.Join(" ", S));
        }

      
    }
}