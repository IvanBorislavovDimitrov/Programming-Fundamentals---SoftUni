using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 0; i < num; i++)
            {
                factorial *= (num - i);
            }
            Console.WriteLine(factorial);
        }
    }
}