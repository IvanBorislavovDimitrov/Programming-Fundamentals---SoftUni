using System;


namespace Program
{
    class Program
    {
        static void Main()
        {
            string line;
            char[] regex = @" +".ToCharArray();
            while ((line = Console.ReadLine()) != "END")
            {
                string[] words = line.Split(regex, StringSplitOptions.RemoveEmptyEntries);
                switch (words[0])
                {
                    case "INC":
                        Console.WriteLine(IncrementByOne(long.Parse(words[1])));
                        break;
                    case "DEC":
                        Console.WriteLine(DecrementByOne(long.Parse(words[1])));
                        break;
                    case "ADD":
                        Console.WriteLine(SumTwoNumbers(long.Parse(words[1]), long.Parse(words[2])));
                        break;
                    case "MLA":
                        Console.WriteLine(MultiplyTwoNumbers(long.Parse(words[1]), long.Parse(words[2])));
                        break;
                }
            }
        }

        public static long MultiplyTwoNumbers(long n1, long n2)
        {
            return n1 * n2;
        }

        public static long SumTwoNumbers(long n1, long n2)
        {
            return n1 + n2;
        }

        public static long DecrementByOne(long number)
        {
            return --number;
        }
        
        public static long IncrementByOne(long number)
        {
            return ++number;
        }
    }
}
