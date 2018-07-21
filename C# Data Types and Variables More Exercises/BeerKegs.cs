using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestVolumeString = "";
            double biggestVolume = -1;
            for (int i = 0; i < n; ++i)
            {
                string nameOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                double heightOfKeg = double.Parse(Console.ReadLine());
                double currentVolume = Math.PI * radiusOfKeg * radiusOfKeg * heightOfKeg;
                if (i == 0)
                {
                    biggestVolume = currentVolume;
                    biggestVolumeString = nameOfKeg;
                }
                if (biggestVolume < currentVolume)
                {
                    biggestVolumeString = nameOfKeg;
                    biggestVolume = currentVolume;
                }
            }
            Console.WriteLine(biggestVolumeString);
        }
    }
}
