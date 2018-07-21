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
            List<string> times = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            times.Sort();
            Console.WriteLine(string.Join(", ", times));
        }
    }
}