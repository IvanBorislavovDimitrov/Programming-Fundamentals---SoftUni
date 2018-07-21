using System;
using System.Collections.Generic;
using System.IO;
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
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string input = Console.ReadLine();
                StringBuilder current = new StringBuilder();
                if (input == "end")
                {
                    break;
                }
                if (Regex.IsMatch(input, @"(<a)(.*)(<\/a>)"))
                {
                    current.Append(Regex.Match(input, @"(<a)(.*)(<\/a>)").Groups[1].Value);
                    current.Append(Regex.Match(input, @"(<a)(.*)(<\/a>)").Groups[2].Value);
                    current.Append(Regex.Match(input, @"(<a)(.*)(<\/a>)").Groups[3].Value);
                    current = current.Replace("<a", "[URL");
                    current = current.Replace("</a>", "[/URL]");
                    current = current.Replace("<", "[");
                    current = current.Replace(">", "]");
                }
                string[] all = Regex.Split(input, @"(<a)(.*)(<\/a>)");
                if (all.Length > 1)
                {
                    current.Insert(0, all[0]);
                    current.Append(all[all.Length - 1]);
                }
                else
                {
                    current.Insert(0, all[0]);
                }

                sb.Append(current + Environment.NewLine);
            }
            Console.WriteLine(sb);
        }
    }
}