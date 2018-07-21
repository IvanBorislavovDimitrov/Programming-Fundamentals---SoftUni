using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPhoto = int.Parse(Console.ReadLine());
            int dayOfPhoto = int.Parse(Console.ReadLine());
            int monthOfPhoto = int.Parse(Console.ReadLine());
            int yearOfPhoto = int.Parse(Console.ReadLine());
            int hourOfPhoto = int.Parse(Console.ReadLine());
            int minuteOfPhoto = int.Parse(Console.ReadLine());
            long sizeOfPhoto = long.Parse(Console.ReadLine());
            int widthOfPhoto = int.Parse(Console.ReadLine());
            int heightOfPhoto = int.Parse(Console.ReadLine());
            string nameOfPhoto = $"DSC_{numberOfPhoto:D4}.jpg";
            string dateTaken = $"{dayOfPhoto:D2}/{monthOfPhoto:D2}/{yearOfPhoto:D4} {hourOfPhoto:D2}:{minuteOfPhoto:D2}";
            string size;
            if (sizeOfPhoto < 1000)
            {
                size = sizeOfPhoto + "B";
            }
            else if (sizeOfPhoto < 1000000)
            {
                size = (sizeOfPhoto / 1000.0) + "KB";
            }
            else
            {
                size = (sizeOfPhoto / 1000000.0) + "MB";
            }
            string mode;
            if (widthOfPhoto == heightOfPhoto)
            {
                mode = "square";
            }
            else if (widthOfPhoto > heightOfPhoto)
            {
                mode = "landscape";
            }
            else
            {
                mode = "portrait";
            }
            Console.WriteLine($"Name: {nameOfPhoto}");
            Console.WriteLine($"Date Taken: {dateTaken}");
            Console.WriteLine($"Size: {size}");
            Console.WriteLine($"Resolution: {widthOfPhoto}x{heightOfPhoto} ({mode})");
        }
    }
}