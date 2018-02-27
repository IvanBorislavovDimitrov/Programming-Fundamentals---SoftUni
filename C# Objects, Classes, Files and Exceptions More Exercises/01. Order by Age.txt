using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Program
{
    
    class Program
    {
        class Person
        {
            public string Name { get; set; }
        
            public string Id { get; set; }
        
            public int Age { get; set; }
        }
        
        static void Main()
        {
            List<Person> people = new List<Person>();
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] infoAboutPerson = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();
                person.Name = infoAboutPerson[0];
                person.Id = infoAboutPerson[1];
                person.Age = int.Parse(infoAboutPerson[2]);
                people.Add(person);
            }
            
            people.Sort((x1, x2) => x1.Age.CompareTo(x2.Age));
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}