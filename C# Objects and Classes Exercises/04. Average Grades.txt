using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Student
    {
        private string nameOfStudent;
        private double[] grades;
        
        public string NameOfStudent
        {
            get => nameOfStudent;
            set => nameOfStudent = value;
        }

        public double[] Grades
        {
            get => grades;
            set => grades = value;
        }

        public double GetAverage()
        {
            return grades.Average();
        }
    }
    class Program
    {
        public static void Main()
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[countOfStudents];
            for (int i = 0; i < students.Length; i++)
            {
                string[] infoAboutStudent = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                students[i] = new Student();
                students[i].NameOfStudent = infoAboutStudent[0];
                students[i].Grades = infoAboutStudent
                    .Skip(1)
                    .Select(x => double.Parse(x)) 
                    .ToArray();
            }
            var sortedStudents = students.ToList();
            sortedStudents.Sort((x1, x2) =>
            {
                if (String.Compare(x1.NameOfStudent, x2.NameOfStudent, StringComparison.Ordinal) == 0)
                {
                    return x2.GetAverage().CompareTo(x1.GetAverage());
                }
                return String.Compare(x1.NameOfStudent, x2.NameOfStudent, StringComparison.Ordinal);
            });
            foreach (var student in sortedStudents)
            {
                double avr = student.GetAverage();
                if (avr >= 5)
                {
                    Console.WriteLine($"{student.NameOfStudent} -> {avr:F2}");
                }
            }
        }
    }
}