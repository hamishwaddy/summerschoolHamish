using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMilesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("************* Convert Miles to KM *************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("Type in the number of miles away you live.");
            double userNum = double.Parse(Console.ReadLine());

            Console.WriteLine("The distance in miles is: {0}", userNum);
            Console.WriteLine("The distance in kilometres is: {0}.", ConvertToKm(userNum));


            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();

        }

        public static double ConvertToKm(double input)
        {
            return input * 0.62137;
        }
    }
}
