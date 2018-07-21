using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int count = 0;
            while (numberOfPeople > 0)
            {
                count++;
                numberOfPeople -= capacityOfElevator;
            }
            Console.WriteLine(count);
        }
    }
}
