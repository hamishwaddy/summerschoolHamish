using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("****************** Min & Max ******************");
            Console.WriteLine("***********************************************");


            Console.WriteLine("\nEnter 5 numbers.");
            Console.Write("Enter number 1 (Array Index 0): ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 (Array Index 1): ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 3 (Array Index 2): ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 4 (Array Index 3): ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 5 (Array Index 4): ");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            int[] minMaxArray = { (num1), (num2),(num3),(num4),(num5) };

            for (int i = 0; i < minMaxArray.Length; i++)
            {
                Console.WriteLine("Number {0} (Array Index {1}): {2}",i+1,i,minMaxArray[i]);
            }

            Console.WriteLine("\nMinimum number in array: {0}", minMaxArray.Min());
            Console.WriteLine("Maximum number in array: {0}", minMaxArray.Max());
           

            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadLine();

        }
    }
}
