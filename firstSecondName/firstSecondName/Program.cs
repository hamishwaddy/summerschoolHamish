using System;

namespace firstSecondName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type your first name and press [enter]: ");
            string firstName = Console.ReadLine();
            Console.Write("Now type your last name and press [enter]: ");
            string lastName = Console.ReadLine();
            Display(firstName, lastName);

        }


        static void Display(string _firstName, string _lastName)
        {
            Console.WriteLine("MY FULL NAME");
            Console.WriteLine("{0} {1}", _firstName, _lastName );

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        
    }
}

