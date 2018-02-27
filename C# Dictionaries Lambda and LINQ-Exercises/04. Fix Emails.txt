using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mails = new Dictionary<string, string>();
            string nameOfOwner;
            while ((nameOfOwner = Console.ReadLine()) != "stop")
            {
                string eMail = Console.ReadLine();
                if (IsMailVaild(eMail))
                {
                    if (!mails.ContainsKey(nameOfOwner))
                    {
                        mails.Add(nameOfOwner, eMail);
                    }
                    else
                    {
                        mails[nameOfOwner] = eMail;
                    }
                }
            }
            foreach (var mail in mails.Keys)
            {
                Console.WriteLine($"{mail} -> {mails[mail]}");
            }
        }

        static bool IsMailVaild(string eMail)
        {
            string lastTwoSymbols = eMail.Substring(eMail.Length - 2).ToLower();
            if (lastTwoSymbols == "us" || lastTwoSymbols == "uk")
            {
                return false;
            }
            return true;
        }
    }
}