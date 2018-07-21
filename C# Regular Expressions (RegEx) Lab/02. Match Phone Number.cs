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
            string regex = @"\+\b[359]+( )2( )\d{3}( )\d{4}\b|\+\b[359]+(-)2(-)\d{3}(-)\d{4}\b";
            string phoneNumbers = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(phoneNumbers, regex);
            var phones = matchCollection
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}