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
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>(); 
            string line;

            while ((line = Console.ReadLine()) != "end") 
            {
                string[] infoAboutUser = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string ipAddres = infoAboutUser[0].Split('=')[1].Trim();
                string username = infoAboutUser[2].Split('=')[1].Trim();

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new Dictionary<string, int>());
                    users[username].Add(ipAddres, 1);
                }
                else
                {
                    if (!users[username].ContainsKey(ipAddres))
                    {
                        users[username].Add(ipAddres, 1);
                    }
                    else
                    {
                        int currentCounter = users[username][ipAddres];
                        users[username][ipAddres] = currentCounter + 1;
                    }
                }
            }
            foreach (string nameOfUser in users.Keys)
            {
                Console.WriteLine($"{nameOfUser}:");
                StringBuilder sb = new StringBuilder();
                foreach (string currentIpAddres in users[nameOfUser].Keys)
                {
                    sb.Append(currentIpAddres);
                    sb.Append(" => ");
                    sb.Append(users[nameOfUser][currentIpAddres]);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append(".");
                Console.WriteLine(sb);
            }
        }
    }
}