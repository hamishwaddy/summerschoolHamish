using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrankWorxMedalAwards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("****Welcome to the CrankWork Medal Awards****");
            Console.WriteLine("*********************************************");


            Console.WriteLine("\nEnter the name of the GOLD medal winner.");
            string goldMedal = Console.ReadLine();

            Console.WriteLine("\nEnter the name of the SILVER medal winner.");
            string silverMedal = Console.ReadLine();

            Console.WriteLine("\nEnter the name of the BRONZE medal winner.");
            string bronzeMedal = Console.ReadLine();

            string[] names = new string[]
           {
               goldMedal, silverMedal, bronzeMedal
           };

            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("****Welcome to the CrankWork Medal Awards****");
            Console.WriteLine("*********************************************");
            Console.Write("\nWhich medal holder would you like to see displayed? (enter 1, 2 or 3)");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThat medal winner is: {names[userInput -1]}");
            
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
