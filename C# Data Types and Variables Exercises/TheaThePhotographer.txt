using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long percentageOfGoodPhotos = long.Parse(Console.ReadLine());
            long amountOfTimeNeededForEveryFilteredPicture = long.Parse(Console.ReadLine());

            long usefulPictures = (long)Math.Ceiling(numberOfPictures * percentageOfGoodPhotos / 100.0);

            long totalPicturesFilterTime = numberOfPictures * filterTime;
            long filteredPictures = usefulPictures * amountOfTimeNeededForEveryFilteredPicture;
            long totalTime = totalPicturesFilterTime + filteredPictures;


            long seconds = totalTime % 60;
            long minutes = totalTime / 60 % 60;
            long hours = totalTime / 60 / 60 % 24;
            long days = totalTime / 60 / 60 / 24;
            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
