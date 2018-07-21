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
            string[] replaceWords = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < replaceWords.Length; i++)
            {
                int countOfStarst = replaceWords[i].Length;
                text = text.Replace(replaceWords[i], new string('*', countOfStarst));
            }
            Console.WriteLine(text);
        }
    }
}
