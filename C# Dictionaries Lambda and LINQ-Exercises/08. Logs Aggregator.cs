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
            SortedDictionary<string, SortedSet<string>> users = new SortedDictionary<string, SortedSet<string>>();
            SortedDictionary<string, long> usersDurations = new SortedDictionary<string, long>();
            int countOfUsers = int.Parse(Console.ReadLine());
            string line;
            for (int i = 0; i < countOfUsers; i++)
            {
                line = Console.ReadLine();
                string[] infoAboutUser = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string ipAddres = infoAboutUser[0];
                string username = infoAboutUser[1];
                long currentDuration = long.Parse(infoAboutUser[2]);

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new SortedSet<string>());
                    users[username].Add(ipAddres);
                    usersDurations.Add(username, currentDuration);
                }
                else
                {
                    if (!users[username].Contains(ipAddres))
                    {
                        users[username].Add(ipAddres);
                        usersDurations[username] += currentDuration;
                    }
                    else
                    {
                        usersDurations[username] += currentDuration;
                    }
                }
            }
            foreach (string user in users.Keys)
            {
                Console.Write($"{user}: {usersDurations[user]} [");
                StringBuilder sb = new StringBuilder();
                foreach (string currentIpAddres in users[user])
                {
                    sb.Append(currentIpAddres);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length - 2, 2);
                Console.WriteLine(sb + "]");
            }
        }
    }
}