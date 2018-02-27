using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();
            switch (parameter)
            {
                case "face":
                    Console.WriteLine($"{GetFaceDiagonal(a):F2}");
                    break;
                case "space":
                    Console.WriteLine($"{GetSpaceDiagonal(a):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{GetVolume(a):F2}");
                    break;
                case "area":
                    Console.WriteLine($"{GetSurfaceArea(a):F2}");
                    break;
            }
        }

        public static double GetSpaceDiagonal(double a)
        {
            return a * Math.Sqrt(3);
        }

        public static double GetFaceDiagonal(double a)
        {
            return a * Math.Sqrt(2);
        }

        public static double GetSurfaceArea(double a)
        {
            return 6 * a * a;
        }

        public static double GetVolume(double a)
        {
            return Math.Pow(a, 3);
        }
    }
}
