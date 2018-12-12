using System;

namespace nameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", how are you?");
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your gender? ");
            string gender = Console.ReadLine();
            Console.WriteLine("What is your street address? ");
            string address = Console.ReadLine();
            Console.Clear();
            Display(name, age, gender, address);
        }

        static void Display(string _name, int _age, string _gender, string _address)

        {
        Console.WriteLine("USER DETAILS");
        Console.WriteLine("Name: " + _name + "\nAge: " + _age + "\nGender: " + _gender + "\nAddress: " + _address);
}
    }
}
