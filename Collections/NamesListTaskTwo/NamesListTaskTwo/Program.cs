using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesListTaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Names List ******************");
            Console.WriteLine("***********************************************\n");

            List<string> Names = new List<string>();

            string userResponse = "y";

            do
            {
                Console.Write("Enter a name: ");
                Names.Add(Console.ReadLine());

                Console.Write("Do you want to add another (y/n): ");
                userResponse =  Console.ReadLine().ToLower();
                
            } while (userResponse == "y");

            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Names List ******************");
            Console.WriteLine("***********************************************\n");

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("\nPress any key to return the main menu.");
            Console.ReadLine();
        }
    }
}
