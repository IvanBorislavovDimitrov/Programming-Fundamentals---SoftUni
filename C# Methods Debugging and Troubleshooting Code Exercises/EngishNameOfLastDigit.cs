using System;


namespace Program
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(GetLastDigit(number));
        }

        public static string GetLastDigit(string number)
        {
            int lastDigit = int.Parse(number[number.Length - 1] + "");
            switch (lastDigit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }
            return "";
        }
    }
}
