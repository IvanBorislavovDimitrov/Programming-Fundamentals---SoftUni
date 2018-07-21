using System; 

namespace CSharpIntroduction
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNumber:D4} {secondNumber:D4} {thirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
