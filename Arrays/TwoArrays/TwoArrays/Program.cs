using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("***************** Two Arrays *****************");
            Console.WriteLine("**********************************************");

            Console.WriteLine("\nEnter 5 numbers into the first array.");
            Console.Write("Enter number 1 (Array Index 0):");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 (Array Index 1):");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 3 (Array Index 2):");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 4 (Array Index 3):");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 5 (Array Index 4):");
            int num5 = int.Parse(Console.ReadLine());

            int[] firstArray = { num1, num2, num3, num4, num5 };

            Console.WriteLine("\nThe numbers entered (first array) were: ");
            foreach (int x in firstArray)
                Console.Write(x + " ");

            int[] secondArray = new int[firstArray.Length];

            Array.Copy(firstArray, secondArray, firstArray.Length);

            Console.WriteLine("\n\nSecond Array:");
            foreach (int x in secondArray)
                Console.WriteLine(x);

            Console.Write("\nSecond Array Sorted: \n");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Array.Sort(secondArray);
                Console.Write(secondArray[i] + " ");
            }

            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadKey();

        }
    }
}
