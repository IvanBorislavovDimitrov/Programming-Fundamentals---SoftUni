using System;
using System.Linq;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                string[] lineSplit = line.Split(' ');
                switch (lineSplit[0])
                {
                    case "Distinct":
                        words = Distinct(words);
                        break;
                    case "Reverse":
                        words = Reverse(words);
                        break;
                    case "Replace":
                        int index = int.Parse(lineSplit[1]);
                        if (index < 0 || index >= words.Length)
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }
                        Replace(words, index, lineSplit[2]);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", words));
        }

        static void Replace(string[] elements, int index, string text)
        {
            elements[index] = text;
        }

        static string[] Reverse(string[] elements)
        {
            string[] tempArr = new string[elements.Length];
            int index = 0;
            for (int i = elements.Length - 1; i >= 0; --i)
            {
                tempArr[index++] = elements[i];
            }
            return tempArr;
        }

        static string[] Distinct(string[] elements)
        {
            for (int i = 0; i < elements.Length - 1; ++i)
            {
                bool isSomethingChanged = false;
                for (int j = i + 1; j < elements.Length; ++j)
                {
                    if (elements[i] == elements[j])
                    {
                        RightShift(elements, j);
                        string[] tempArr = new string[elements.Length - 1];
                        Array.Copy(elements, tempArr, elements.Length - 1);
                        elements = tempArr;
                        isSomethingChanged = true;
                    }   
                }
                if (isSomethingChanged)
                {
                    --i;
                }
            }
            return elements;
        }

        static void RightShift(string[] elements, int startIndex)
        {
            for (int i = startIndex; i < elements.Length - 1; ++i)
            {
                string swap = elements[i];
                elements[i] = elements[i + 1];
                elements[i + 1] = swap;
            }
        }
    }
}
