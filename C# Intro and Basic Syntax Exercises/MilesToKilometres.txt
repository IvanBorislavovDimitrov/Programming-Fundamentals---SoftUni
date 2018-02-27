using System; 

namespace CSharpIntroduction
{
    class Program
    {
   
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(miles * 1.60934):F2}");
        }
    }
}
