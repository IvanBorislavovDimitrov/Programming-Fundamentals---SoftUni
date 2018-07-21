using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] arr = text.ToCharArray();

            int indexOfFirst = text.IndexOf("<");
            int indexOfSecond = text.IndexOf(">");
            
            while (indexOfFirst != -1 && indexOfSecond != -1)
            {
                
                int diff = Math.Abs(text[indexOfFirst + 1] - text[indexOfFirst + 2]);
                if (indexOfFirst != -1 && indexOfSecond != -1)
                {
                    arr[indexOfFirst] = '_';
                    arr[indexOfSecond] = '_';
                    arr[indexOfFirst + 1] = '_';
                    arr[indexOfSecond - 1] = '_';
                }
                for (int i = 0; i < diff; i++)
                {
                    if (indexOfFirst - i - 1 >= 0)
                    {
                        arr[indexOfFirst - i - 1] = '_';
                    }
                    if (indexOfSecond + i + 1 < arr.Length)
                    {
                        arr[indexOfSecond + i + 1] = '_';
                    }
                }
                text = string.Join("", arr);
                indexOfFirst = text.IndexOf("<");
                indexOfSecond = text.IndexOf(">");
            }
            Console.WriteLine(text);
        }
    }
}
