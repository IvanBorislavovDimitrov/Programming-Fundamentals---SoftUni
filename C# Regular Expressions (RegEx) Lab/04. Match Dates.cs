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
            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string dates = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(dates, regex);
            foreach (Match m in matchCollection)
            {
                Console.WriteLine($"Day: {m.Groups["day"].Value}, Month: {m.Groups["month"].Value}, Year: {m.Groups["year"].Value}");
            }
        }
    }
}