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
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string text = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(text, regex);
            var mc = matchCollection
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(" ", mc));
        }

       
    }
}