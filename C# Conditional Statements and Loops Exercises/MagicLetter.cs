using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            char[] arr = new char[3];
            for (char i = first; i <= second; ++i)
            {
                if (i == third)
                {
                    continue;
                }
                arr[0] = i;
                for (char j = first; j <= second; ++j)
                {
                    if (j == third)
                    {
                        continue;
                    }
                    arr[1] = j;
                    for (char k = first; k <= second; ++k)
                    {
                        if (k == third)
                        {
                            continue;
                        }
                        arr[2] = k;
                        Console.Write($"{arr[0]}{arr[1]}{arr[2]} ");
                    }
                }
            }
        }
    }
}
