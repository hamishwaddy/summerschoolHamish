using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOneAddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("************** Add Two Numbers ****************");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("This app will ask for 2 numbers and will then calculate the sum of all the numbers between those 2 numbers.\n");
            Console.Write("Please enter the first (lowest) number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second (highest) number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int total = 0;
            for (int i = num1 + 1; i < num2; i++)
            {
                total = total + i;
            }
            Console.WriteLine("\nThe sum of all numbers between {0} and {1} is: {2}", num1, num2, total);
            
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
