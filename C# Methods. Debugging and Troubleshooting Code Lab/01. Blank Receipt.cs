using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            GiveInfo();
        }
        public static string CashReciept()
        {
            return "CASH RECEIPT\n------------------------------";
        }
        public static string ChargedToAndRecievedBy()
        {
            return "Charged to____________________\nReceived by___________________";
        }
        public static string Softuni()
        {
            return "------------------------------\n© SoftUni";
        }
        public static void GiveInfo()
        {
            Console.WriteLine(CashReciept());
            Console.WriteLine(ChargedToAndRecievedBy());
            Console.WriteLine(Softuni());
        }
    }
}
