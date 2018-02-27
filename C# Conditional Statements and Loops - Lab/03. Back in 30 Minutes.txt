using System;


namespace _2zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int allTime = hour * 60 + minutes + 30;
            int newHour = allTime / 60;
            int newMinutes = allTime % 60;
            if (newHour > 23)
            {
                newHour %= 24;
            }
           
              Console.WriteLine($"{newHour}:{newMinutes:D2}");
           
        }
    }
}
