using System;


namespace _2zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
