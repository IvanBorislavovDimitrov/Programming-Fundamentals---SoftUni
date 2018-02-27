using System;


namespace Program
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int biggerThanFirstTwo = GetMax(a, b);
            Console.WriteLine(GetMax(c, biggerThanFirstTwo));
        }

        public static int GetMax(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
    }
}
