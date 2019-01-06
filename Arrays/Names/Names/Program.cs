using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("******************* Names *******************");
            Console.WriteLine("*********************************************");

            Console.WriteLine("You are going to be asked to type five names.");
            Console.Write("\nPlease type the first name and press enter: ");
            string name1 = Console.ReadLine();
            Console.Write("Please type the second name and press enter: ");
            string name2 = Console.ReadLine();
            Console.Write("Please type the third name and press enter: ");
            string name3 = Console.ReadLine();
            Console.Write("Please type the fourth name and press enter: ");
            string name4 = Console.ReadLine();
            Console.Write("Please type the fifth name and press enter: ");
            string name5 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("******************* Names *******************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Here are the five names you entered:");
            Console.WriteLine("1- " + name1);
            Console.WriteLine("2- " + name2);
            Console.WriteLine("3- " + name3);
            Console.WriteLine("4- " + name4);
            Console.WriteLine("5- " + name5);


            string[] names = new string[]
                { name1, name2, name3, name4, name5 };
            
            Console.WriteLine("\nThe first name entered is: " + names[0]);
            Console.WriteLine("The last name entered is: " + names[4]);
            
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}
