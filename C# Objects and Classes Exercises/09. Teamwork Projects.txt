using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Club
    {
        public string Creator { get; set; }
        
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Club> teams = new Dictionary<string, Club>();
            int countOfClubs = int.Parse(Console.ReadLine());
            CreateClubs(teams, countOfClubs);
            JoinToTheClub(teams);
            PrintValidClub(teams);
            PrintInvalidClub(teams);
        }

        static void PrintInvalidClub(Dictionary<string, Club> teams)
        {
            Console.WriteLine("Teams to disband:");
            var sortedTeams = teams.ToList();
            sortedTeams.Sort((x1, x2) => String.Compare(x1.Key, x2.Key, StringComparison.Ordinal));
            foreach (var sortedTeam in sortedTeams)
            {
                if (sortedTeam.Value.Members.Count == 0)
                {
                    Console.WriteLine(sortedTeam.Key);
                }
            }
        }

        static bool DoesUserExistAnywhere(Dictionary<string, Club> teams, string nameOfUser)
        {
            foreach (string team in teams.Keys)
            {
                foreach (var member in teams[team].Members)
                {
                    if (member == nameOfUser)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void PrintValidClub(Dictionary<string, Club> teams)
        {
            var validClubs = teams.ToList();
            validClubs.Sort((x1, x2) =>
            {
                if (x1.Value.Members.Count == x2.Value.Members.Count)
                {
                    return String.Compare(x1.Key, x2.Key, StringComparison.Ordinal);
                }
                return x2.Value.Members.Count.CompareTo(x1.Value.Members.Count);
            });
            foreach (var validClub in validClubs)
            {
                if (validClub.Value.Members.Count > 0)
                {
                    validClub.Value.Members.Sort();
                    Console.WriteLine(validClub.Key);
                    Console.WriteLine($"- {validClub.Value.Creator}");
                    foreach (var member in validClub.Value.Members)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
        }

        static void JoinToTheClub(Dictionary<string, Club> teams)
        {
            string line;
            while ((line = Console.ReadLine()) != "end of assignment")
            {
                string[] infoAboutUser = line
                    .Split(new[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                string nameOfUserWhoWantsToJoin = infoAboutUser[0];
                string clubToJoin = infoAboutUser[1];
                
                if (!teams.ContainsKey(clubToJoin))
                {
                    Console.WriteLine($"Team {clubToJoin} does not exist!");
                }
                else if (DoesUserWhoWantsToJoinExist(teams, nameOfUserWhoWantsToJoin))
                {
                    Console.WriteLine($"Member {nameOfUserWhoWantsToJoin} cannot join team " +
                                      $"{clubToJoin}!");
                }
                else if (DoesUserExistAnywhere(teams, nameOfUserWhoWantsToJoin))
                {
                    Console.WriteLine($"Member {nameOfUserWhoWantsToJoin} cannot join team " +
                                      $"{clubToJoin}!");
                }
                else
                {
                    teams[clubToJoin].Members.Add(nameOfUserWhoWantsToJoin);
                }
            }
        }

        static bool DoesUserWhoWantsToJoinExist(Dictionary<string, Club> teams, string username)
        {
            foreach (string team in teams.Keys)
            {
                if (teams[team].Creator == username)
                {
                    return true;
                }
            }
            return false;
        }

        static void CreateClubs(Dictionary<string, Club> teams, int countOfClubs)
        {
            for (int i = 0; i < countOfClubs; i++)
            {
                string[] infoAboutClub = Console.ReadLine().Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                string nameOfCreator = infoAboutClub[0];
                string nameOfClub = infoAboutClub[1];

                if (teams.ContainsKey(nameOfClub))
                {
                    Console.WriteLine($"Team {nameOfClub} was already created!");
                    continue;
                }
                if(DoesCreatorExist(teams, nameOfCreator))
                {
                    Console.WriteLine($"{nameOfCreator} cannot create another team!");
                    continue;
                }
                teams.Add(nameOfClub, new Club());
                teams[nameOfClub].Creator = nameOfCreator;
                teams[nameOfClub].Members = new List<string>();
                Console.WriteLine($"Team {nameOfClub} has been created by {nameOfCreator}!");
            }
        }

        static bool DoesCreatorExist(Dictionary<string, Club> teams, string nameOfCreator)
        {
            foreach (string team in teams.Keys)
            {
                if (teams[team].Creator == nameOfCreator)
                {
                    return true;
                }
            }
            return false;
        }

    }
}