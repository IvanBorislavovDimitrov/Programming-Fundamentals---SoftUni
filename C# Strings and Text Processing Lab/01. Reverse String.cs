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
            string str = Console.ReadLine();
            Console.WriteLine(string.Join("", str.Reverse()));
        }
    }
}
