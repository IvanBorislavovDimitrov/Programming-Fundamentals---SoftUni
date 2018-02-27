using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine().ToLower();
            string toFind = Console.ReadLine().ToLower();
            int index = str.IndexOf(toFind);
            int count = 0;
            while (index != -1)
            {
                index = str.IndexOf(toFind, index + 1);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
