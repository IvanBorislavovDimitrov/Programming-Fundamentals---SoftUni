using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Program
{
    class Student
    {
        public string NameOfStudent { get; set; }
        
        public List<DateTime> Dates { get; set; }
        
        public List<string> Comments { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            
            ReadDates(students);
            
            ReadComments(students);
            
            PrintResult(students);
        }

        static void PrintResult(List<Student> students)
        {
            List<Student> sortedStudents = students.ToList();
            if (sortedStudents.Count != 0)
            {
                sortedStudents.Sort((x1, x2) => String.Compare(x1.NameOfStudent, x2.NameOfStudent,
                    StringComparison.Ordinal));
            }
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.NameOfStudent);
                Console.WriteLine("Comments:");
                foreach (string comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                List<DateTime> sortedDates = student.Dates.ToList();
                if (sortedDates.Count != 0)
                {
                    sortedDates.Sort();
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in sortedDates)
                {
                    Console.WriteLine($"-- {date.Day:D2}/{date.Month:D2}/{date.Year}");
                }
            }
        }

        static void ReadComments(List<Student> students)
        {
            string line;
            while ((line = Console.ReadLine()) != "end of comments")
            {
                string[] infoAboutComment = line.Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                string nameOfStudent = infoAboutComment[0];
                string comment = infoAboutComment[1];
                int indexOfStudent = IndexOfStudent(students, nameOfStudent);
                if (indexOfStudent != -1)
                {
                    students[indexOfStudent].Comments.Add(comment);
                }
            }
        }

        static void ReadDates(List<Student> students)
        {
           string line;
            while ((line = Console.ReadLine()) != "end of dates")
            {
                string[] infoAboutStudent = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string nameOfStudent = infoAboutStudent[0];
                int indexOfStudent = IndexOfStudent(students, nameOfStudent);
                if (infoAboutStudent.Length < 2)
                {
                    if (indexOfStudent == -1)
                    {
                        Student student = new Student();
                        student.NameOfStudent = nameOfStudent;
                        student.Dates = new List<DateTime>();
                        student.Comments = new List<string>();
                        students.Add(student);
                        continue;
                    }
                }
                DateTime[] dates = GetDates(infoAboutStudent[1]);
                if (indexOfStudent == -1)
                {
                    Student student = new Student();
                    student.NameOfStudent = nameOfStudent;
                    student.Dates = new List<DateTime>();
                    student.Comments = new List<string>();
                    if (dates != null)
                        student.Dates.AddRange(dates);
                    students.Add(student);
                }
                else
                {
                    if (dates != null)
                        students[indexOfStudent].Dates.AddRange(dates);
                }
            }    
        }

        static DateTime[] GetDates(string dates)
        {
            if (dates.Length != 0)
            {
                return dates.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToArray();
            }
            return null;
        }

        static int IndexOfStudent(List<Student> students, string nameOfStudent)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].NameOfStudent == nameOfStudent)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}