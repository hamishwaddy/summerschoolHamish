using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Rounding Money ***************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("This application will work out whether to round your change up or down.");
            Console.WriteLine("If the amount ends in a 1, 2, 3, 4 or 5 your total will round down.");
            Console.WriteLine("If the amount ends in a 6, 7, 8 or 9 your total will round up.");
            Console.Write("\nPlease enter the last digit of the cents amount: ");

            int endingCents = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nFor this amount you need to {0}.", RoundingDecision(endingCents));

            Console.WriteLine("\n" +
                "Press any key to return to the main menu.");
            Console.ReadLine();
        }

        public static string RoundingDecision(int endingCents)
        {
            string result = "";

            switch (endingCents)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    result = "round down";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    result = "round up";
                    break;
            }
            return result;
        }
    }
}
