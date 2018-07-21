using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftBrackets = 0;
            int rightBrackets = 0;
            bool flag = true;
            for (int i = 0; i < n; ++i)
            {
                string line = Console.ReadLine();
              
                if (line.Contains("()"))
                {
                    continue;
                }
                if (line.Contains("(") && line.Length == 1)
                {
                    if (!flag)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    leftBrackets++;
                    flag = false;
                }
                else if (line.Contains(")") && line.Length == 1)
                {
                    if (flag)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    rightBrackets++;
                    flag = true;
                }
            }
            if (rightBrackets == leftBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
