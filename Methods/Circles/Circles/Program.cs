using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("******************* Circles *******************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("\nWhat is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******************* Circles *******************");
            Console.WriteLine("***********************************************");
            Console.Write("\nThe radius of your circle was: {0}.", radius);
            Console.WriteLine("\nThe circumference of your circle is: {0}.", ConvertToCircumference(radius));
            Console.WriteLine("The area of your circle is: {0}.", ConvertToArea(radius));

            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();

        }

        public static double ConvertToCircumference(double input)
        {
            return input * 2 * 3.1416;
        }

        public static double ConvertToArea(double input)
        {
            return input * input * 3.1416; 
        }
    }
}
