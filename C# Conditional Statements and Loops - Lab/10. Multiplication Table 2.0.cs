using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("{0} X {1} = {2}", n, count, n * count);
                count++;
            } while (count <= 10);
        }
    }
}
