using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("******************* Reverse *******************");
            Console.WriteLine("***********************************************");

            Console.WriteLine("Enter 5 numbers.");
            Console.WriteLine("Enter number 1 (Array Index 0):");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 5 numbers.");
            Console.WriteLine("Enter number 2 (array Index 1):");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 5 numbers.");
            Console.WriteLine("Enter number 3 (array Index 2):");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 5 numbers.");
            Console.WriteLine("Enter number 4 (array Index 3):");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 5 numbers.");
            Console.WriteLine("Enter number 5 (array Index 4):");
            int num5 = int.Parse(Console.ReadLine());

            int[] numsArray = { num1, num2, num3, num4, num5 };

            Console.WriteLine("\n\nNumbers displayed as entered: ");
            Console.WriteLine("______________________________");

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("\n\nNumbers displayed in reverse:");
            Console.WriteLine("______________________________");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Array.Sort(numsArray);
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
            
        }
    }
}
