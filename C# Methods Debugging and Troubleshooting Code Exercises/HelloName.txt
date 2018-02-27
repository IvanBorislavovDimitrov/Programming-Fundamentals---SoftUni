using System;


namespace Program
{
    class Program
    {
        static void Main()
        {
            SayHello(Console.ReadLine());
        }

        public static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
