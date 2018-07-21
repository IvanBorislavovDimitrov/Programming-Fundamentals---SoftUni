using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());
            double bars = Math.Round(numberOfBeats / 4.0, 1);
            double beatForSecond = ((double)numberOfBeats / beatsPerMinute); 
            int numberOfBeatsInSeconds = (int)(Math.Floor(beatForSecond * 60));
            Console.WriteLine($"{bars} bars - {(numberOfBeatsInSeconds / 60)}m {(numberOfBeatsInSeconds % 60)}s");
                
        }
    }
}