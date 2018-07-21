using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            bool flag = true;
            for (int first = n1; first <= n2; ++first)
            {
                for (int second = n1; second <= n2; ++second)
                {
                    for (int third = n1; third <= n2; ++third)
                    {
                        for (int fourth = n1; fourth <= n2; ++fourth)
                        {
                            for (int fifth = n1; fifth <= n2; ++fifth)
                            {
                                if (first < second && second < third && third < fourth && fourth < fifth)
                                {
                                    Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                                    flag = false;
                                }
                            }
                        }
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("No");
            }
        }
    }
}
