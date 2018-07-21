using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection match = Regex.Matches(Console.ReadLine(), "\\b[A-Z][a-z]+ [A-Z][a-z]+\\b");
            foreach (var m in match)
            {
                Console.Write(m + " ");
            }
            
        }
    }
}