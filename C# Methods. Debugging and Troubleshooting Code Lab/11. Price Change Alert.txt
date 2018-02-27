using System;


namespace Program
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double number = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                double percent = CalculatePercent(number, currentNumber);
                bool isSignificantDifference = IsSignificantDiffernce(percent, treshold);
                string message = GetCurrentStr(currentNumber, number, percent * 100, isSignificantDifference);
                Console.WriteLine(message);
                number = currentNumber;
            }
        }

        private static string GetCurrentStr(double currnetNumber, double lastNumber, double difference, bool IsSignificantDiffernce)
        {
            string str = "";
            if (difference == 0)
            {
                str = string.Format("NO CHANGE: {0}", currnetNumber);
            }
            else if (!IsSignificantDiffernce)
            {
                str = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastNumber, currnetNumber, difference);
            }
            else if (IsSignificantDiffernce && (difference > 0))
            {
                str = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastNumber, currnetNumber, difference);
            }
            else if (IsSignificantDiffernce && (difference < 0))
                str = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastNumber, currnetNumber, difference);
            return str;
        }

        private static bool IsSignificantDiffernce(double percent, double treshold)
        {
            if (Math.Abs(percent) >= treshold)
            {
                return true;
            }
            return false;
        }

        private static double CalculatePercent(double firstNum, double secondNum)
        {
            return (secondNum - firstNum) / firstNum;
        }
    }
}
