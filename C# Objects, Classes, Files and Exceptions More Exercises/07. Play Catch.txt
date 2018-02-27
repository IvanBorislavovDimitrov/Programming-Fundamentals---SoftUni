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
            long[] arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            int countOfExceptions = 0;
            while (countOfExceptions < 3)
            {
                string[] info = Console.ReadLine().Split(new[] { ' ' });
                /*if (info.Length == 0)
                {
                    Console.WriteLine("The index does not exist!");
                    countOfExceptions++;
                    continue;
                }*/
                switch (info[0])
                {
                    case "Replace":
                        try
                        {
                            long index = long.Parse(info[1]);
                            long element = long.Parse(info[2]);
                            if (index < 0 || index >= arr.Length)
                            {
                                Console.WriteLine("The index does not exist!");
                                countOfExceptions++;
                            }
                            else
                            {
                                arr[index] = element;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            countOfExceptions++;
                        }
                        break;
                    case "Print":
                        try
                        {
                            long startIndex = long.Parse(info[1]);
                            long endIndex = long.Parse(info[2]);
                            if (startIndex > endIndex)
                            {
                                Console.WriteLine("The index does not exist!");
                                countOfExceptions++;
                            }
                            if (startIndex < 0 || startIndex >= arr.Length)
                            {
                                Console.WriteLine("The index does not exist!");
                                countOfExceptions++;
                            }
                            else if (endIndex < 0 || endIndex >= arr.Length)
                            {
                                Console.WriteLine("The index does not exist!");
                                countOfExceptions++;
                            }
                            else
                            {
                                StringBuilder sb = new StringBuilder();
                                for (long i = startIndex; i <= endIndex; i++)
                                {
                                    sb.Append(arr[i]);
                                    sb.Append(", ");
                                }
                                Console.WriteLine(sb.ToString().Substring(0, sb.Length - 2));
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            countOfExceptions++;
                        }
                        break;
                    case "Show":
                        try
                        {
                            long index = long.Parse(info[1]);
                            if (index < 0 || index >= arr.Length)
                            {
                                Console.WriteLine("The index does not exist!");
                                countOfExceptions++;
                            }
                            else
                            {
                                Console.WriteLine(arr[index]);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            countOfExceptions++;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }

    }
}
