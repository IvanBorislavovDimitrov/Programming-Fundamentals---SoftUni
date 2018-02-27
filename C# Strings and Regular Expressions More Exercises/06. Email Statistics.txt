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
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();
            int countOfEmails = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfEmails; i++)
            {
                string email = Console.ReadLine();
                int indexOfAt = email.IndexOf("@");
                if (indexOfAt == -1)
                {
                    continue;
                }
                string username = email.Substring(0, indexOfAt);
                if (!IsUsernameValid(username))
                {
                    continue;
                }
                string mailServerAndDomain = email.Substring(indexOfAt + 1);
                string mailServer = mailServerAndDomain.Split('.')[0];
                if (!IsMailServerValid(mailServer))
                {
                    continue;
                }
                string domain = mailServerAndDomain.Split('.')[1];
                if (!IsDomainValid(domain))
                {
                    continue;
                }
                mailServerAndDomain = mailServer + "." + domain;
                if (!emails.ContainsKey(mailServerAndDomain))
                {
                    emails.Add(mailServerAndDomain, new List<string>());
                    emails[mailServerAndDomain].Add(username);
                }
                else
                {
                    if (!emails[mailServerAndDomain].Any(x => x == username))
                    {
                        emails[mailServerAndDomain].Add(username);
                    }
                }
            }

            foreach (var mailServerAndDomain in emails.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine(mailServerAndDomain.Key + ":");
                foreach (var name in emails[mailServerAndDomain.Key])
                {
                    Console.WriteLine($"### {name}");
                }
            }

        }

        static bool IsMailServerValid(string mailServer)
        {
            if (mailServer.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < mailServer.Length; i++)
            {
                if (!char.IsLower(mailServer[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsDomainValid(string domain)
        {
            if (domain == "com" || domain == "bg" || domain == "org")
            {
                return true;
            }
            return false;
        }

        static bool IsUsernameValid(string username)
        {
            if (username.Length < 5)
            {
                return false;
            }
            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetter(username[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}