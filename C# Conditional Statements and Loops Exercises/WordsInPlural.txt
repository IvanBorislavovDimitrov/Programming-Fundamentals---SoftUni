using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            if (noun[noun.Length - 1] == 'y')
            {
                noun = noun.Substring(0, noun.Length - 2);
                noun += "ies";
            }
            else if (noun[noun.Length - 1] == 'o' || noun[noun.Length - 1] == 's' || noun[noun.Length - 1] == 'x' ||
                noun[noun.Length - 1] == 'z' || (noun[noun.Length - 2] == 's' && noun[noun.Length - 1] == 'h') ||
                (noun[noun.Length - 2] == 'c' && noun[noun.Length - 1] == 'h'))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }
            Console.WriteLine(noun);
        }
    }
}
