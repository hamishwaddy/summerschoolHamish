using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnOppositeSign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("************* Return Opposite Sign ************");
            Console.WriteLine("***********************************************");

            Console.Write("\nEnter a number: ");
            int userNum = int.Parse(Console.ReadLine());
            
            int swapped = SwapNumber(userNum);
            
            Console.WriteLine("Your swapped number is: {0}", swapped);


            

            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();
        }

        public static int SwapNumber(int input)
        {
            var swapped = input * -1;
            return swapped;
        }

       public static double SwapNumber(double input)
        {
            return input * -1;
        }
    }
}
