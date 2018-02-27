using System;


namespace _2zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            bool isFalse = true;
            switch (typeOfDay)
            {
                case "weekday":
                    if (age >= 0 && age <= 18)
                    {
                         price = 12;
                        isFalse = false;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                        isFalse = false;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 12;
                        isFalse = false;
                    }
                    break;
                case "weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                        isFalse = false;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                        isFalse = false;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 15;
                        isFalse = false;
                    }
                    break;
                case "holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                        isFalse = false;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                        isFalse = false;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                        isFalse = false;
                    }
                    break;
            }
            if (isFalse)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(price + "$");
            }
        }
    }
}
