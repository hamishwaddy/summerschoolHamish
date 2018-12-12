using System;

namespace firstSecondName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Now type your last name: ");
            string lastName = Console.ReadLine();
            Display(firstName, lastName);

        }


        static void Display(string _firstName, string _lastName)
        {
            Console.WriteLine("MY FULL NAME");
            Console.WriteLine("{0} {1}", _firstName, _lastName );
        }


    }
}

