using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            sbyte n1;
            byte n2;
            short n3;
            ushort n4;
            int n5;
            uint n6;
            long n7;
            bool flag = false;
            
            if (sbyte.TryParse(a, out n1))
            {
                Console.WriteLine(a + " can fit in:");
                Console.WriteLine("* sbyte");
                flag = true;
                
            }
            if (byte.TryParse(a, out n2))
            {
                if (!flag)
                {
                    Console.WriteLine(a + " can fit in:");
                }
                Console.WriteLine("* byte");
                flag = true;
            }
            if (short.TryParse(a, out n3))
            {
                if (!flag)
                {
                    Console.WriteLine(a + " can fit in:");
                }
                Console.WriteLine("* short");
                flag = true;
            }
            if (ushort.TryParse(a, out n4))
            {
                if (!flag)
                {
                    Console.WriteLine(a + " can fit in:");
                }
                Console.WriteLine("* ushort");
                flag = true;
            }
            if (int.TryParse(a, out n5))
            {
                if (!flag)
                {
                    Console.WriteLine(a + " can fit in:");
                }
                Console.WriteLine("* int");
                flag = true;
            }
            if (uint.TryParse(a, out n6))
            {
                if (!flag)
                {
                    Console.WriteLine(a + " can fit in:");
                }
                Console.WriteLine("* uint");
                flag = true;
            }
            if (long.TryParse(a, out n7))
            {
                if (!flag)
                {
                    Console.WriteLine(a + " can fit in:");
                }
                Console.WriteLine("* long");
                flag = true;
            }
            if (!flag)
            {
                Console.Write(a);
                Console.WriteLine(" can't fit in any type");
            }
        }
    }
}
