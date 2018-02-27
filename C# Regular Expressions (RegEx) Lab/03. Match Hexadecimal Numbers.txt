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
            string regex = @"\b(0x)?[\d?A?B?C?D?E?F?]+\b";
            string hexaDecimalNumbers = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(hexaDecimalNumbers, regex);
            var nums = matchCollection
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}