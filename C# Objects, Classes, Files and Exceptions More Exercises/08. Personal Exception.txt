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
    class MyPersonalException : SystemException
    {
        public MyPersonalException() : base()
        {
        }

        public string Message()
        {
            return "My first exception is awesome!!!";
        }
    }
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        throw new MyPersonalException();
                    }
                    Console.WriteLine(n);
                }
                catch (MyPersonalException e)
                {
                    Console.WriteLine(e.Message());
                    return;
                }
               
            }
        }
    }
}
