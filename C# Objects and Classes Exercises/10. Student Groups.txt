using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Program
{
    class Student
    {
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        
        public int SeatCounts { get; set; }
        
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        
        public List<Student> Students { get; set; }
    }
    
    class Program
    {
        static void Main()
        {
            List<Town> towns = ReadTownsAndStudents();

            List<Group> groups = DistrubuteGroups(towns);
            
            PrintGroups(groups, towns);
        }

        static void PrintGroups(List<Group> groups, List<Town> towns)
        {
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (var group in groups)
            {
                Console.Write($"{group.Town.Name} => ");
                StringBuilder sb = new StringBuilder();
                foreach (Student student in group.Students)
                {
                    sb.Append(student.Email);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length - 2, 2);
                Console.WriteLine(sb);
            }
        }

        static List<Group> DistrubuteGroups(List<Town> towns) 
        {
            List<Group> groups = new List<Group>();
            towns.Sort((x1, x2) => String.Compare(x1.Name, x2.Name, StringComparison.Ordinal));
            for (int i = 0; i < towns.Count; i++)
            {
                IEnumerable<Student> students = towns[i].Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email);
                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = towns[i];
                    group.Students = students.Take(group.Town.SeatCounts).ToList();
                    students = students.Skip(group.Town.SeatCounts);
                    groups.Add(group);
                }
            }
            return groups;
        }

        static List<Town> ReadTownsAndStudents()
        {
            List<Town> towns = new List<Town>();
            string line;

            int currentPosition = -1;
            while ((line = Console.ReadLine()) != "End")
            {
                if (line.Contains("=>"))
                {
                    string[] infoAboutTown = line.Split(new[] {" => "}, StringSplitOptions.RemoveEmptyEntries);
                    string townName = infoAboutTown[0];
                    int seats = int.Parse(infoAboutTown[1].Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)[0]);
                    
                    Town town = new Town();
                    town.Name = townName;
                    town.SeatCounts = seats;
                    town.Students = new List<Student>();
                    towns.Add(town);
                    currentPosition++;
                }
                else
                {
                    string[] infoAboutStudent = line.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
                    string nameOfStudent = infoAboutStudent[0].Trim();
                    string emailOfStudent = infoAboutStudent[1].Trim();
                    string date = infoAboutStudent[2].Trim().ToUpper();
                    DateTime registrationDate = DateTime
                        .ParseExact(date, "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    
                    Student student = new Student();
                    student.Name = nameOfStudent;
                    student.Email = emailOfStudent;
                    student.RegistrationDate = registrationDate;
                    towns[currentPosition].Students.Add(student);
                }
            }
            return towns;
        }
    }
}