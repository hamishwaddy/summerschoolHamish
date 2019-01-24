using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("******************* Total ********************");
            Console.WriteLine("**********************************************");

            Console.WriteLine("How many numbers do you want to store in the array?");
            int totalArrayNumbers = int.Parse(Console.ReadLine());
            int total = 0;

            int[] userArray = new int[totalArrayNumbers];

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write("Number {0} (Array Index {1}): ",i+1, i);
                userArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("\nNumbers displayed as entered:");
            for (int i = 0; i < userArray.Length; i++)
            {
                //Console.WriteLine("Number " + (i+1) + "(Array index " + (i) + "): " + userArray[i]);
                //Console.WriteLine($"Number {i+1} (Array index {i}): {userArray[i]}");
                Console.WriteLine("Number {0}  (Array index {1}): {2}", i + 1, i, userArray[i]);
            }
            Console.Write("\nUser entered: ");
            foreach (int x in userArray)
            {
                Console.Write(x + " ");
                total = total + x;
            }

            Console.Write("\nTotal of these array items: {0}", total);
            
            Console.WriteLine("\n\nPress any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
